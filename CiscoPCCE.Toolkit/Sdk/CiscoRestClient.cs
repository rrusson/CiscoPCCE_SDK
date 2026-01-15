using System.Net.Http.Headers;
using System.Text;
using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Bean;
using CiscoPCCE.Toolkit.Sdk.Helpers;
using CiscoPCCE.Toolkit.Sdk.Interfaces;

namespace CiscoPCCE.Toolkit.Sdk
{
    /// <summary>
    /// A simple SSL REST Client wrapper to handle CRUD API calls to Cisco services
    /// </summary>
    public class CiscoRestClient : ICiscoRestClient
    {
        /// <summary>
        /// HTTP Client for handling CRUD calls
        /// </summary>
        private readonly HttpClient httpClient;

        /// <summary>
        /// Base URL for the Cisco PCCE API
        /// </summary>
        public const string BaseUrl = "/unifiedconfig/config/";

        public int MaxResults { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="hostName">Fully qualified host name or IP</param>
        /// <param name="username">Fully qualified username (with @domain)</param>
        /// <param name="password">User's password</param>
        /// <param name="maxResults">Optional maximum result count</param>
        public CiscoRestClient(string hostName, string username, string password, int maxResults = 25)
        {
            // Create HTTP client handler that accepts all SSL certificates
            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true,
                SslProtocols = System.Security.Authentication.SslProtocols.Tls12
            };

            httpClient = new HttpClient(handler)
            {
                BaseAddress = hostName.StartsWith("http") ? new Uri(hostName) : new Uri($"https://{hostName}")
            };

            // Add basic authentication
            var authToken = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{password}"));
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authToken);

            MaxResults = maxResults;
        }

        /// <inheritdoc/>
        public async Task<HttpResponseMessage> CreateAsync<T>(T bean, string? path = null) where T : BaseApiBean
        {
            try
            {
                if (string.IsNullOrEmpty(path))
                {
                    path = GetPathFromType<T>();
                }

                var xmlContent = SerializeXml(bean);
                var content = new StringContent(xmlContent, Encoding.UTF8, "application/xml");

                var response = await httpClient.PostAsync($"{BaseUrl}{path}", content);

                if (response.StatusCode is not System.Net.HttpStatusCode.OK and
                    not System.Net.HttpStatusCode.Created and
                    not System.Net.HttpStatusCode.Accepted)
                {
                    await HandleErrorsAsync(response);
                }

                return response;
            }
            catch (HttpRequestException ex)
            {
                throw new ApiException($"HTTP request failed: {ex.Message}");
            }
        }

        /// <inheritdoc/>
        public async Task<string?> CreateAndGetAsync<T>(T bean, string? path = null) where T : BaseApiBean
        {
            var response = string.IsNullOrWhiteSpace(path) ? await CreateAsync(bean) : await CreateAsync(bean, path);
            return GetLocationFromResponse(response);
        }

        /// <inheritdoc/>
        public async Task DeleteAsync(string refURL)
        {
            try
            {
                var response = await httpClient.DeleteAsync(refURL);
                _ = response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException ex)
            {
                throw new ApiException($"HTTP request failed: {ex.Message}");
            }
        }

        /// <inheritdoc/>
		public async Task DeleteByIdAsync<T>(string id) where T : BaseApiBean
        {
            var path = GetPathFromType<T>();
            await DeleteAsync($"{BaseUrl}{path}/{id}");
        }

        /// <inheritdoc/>
        public async Task<T?> GetAsync<T>(string refURL) where T : BaseApiBean
        {
            refURL += (refURL.Contains("?q=") ? "&" : "?") + $"resultsPerPage={MaxResults}";

            try
            {
                var response = await httpClient.GetAsync(refURL);
                _ = response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
                return DeserializeXml<T>(content);
            }
            catch (HttpRequestException ex)
            {
                throw new ApiException($"HTTP request failed: {ex.Message}");
            }
        }

        /// <inheritdoc/>
        public async Task<T?> GetByIdAsync<T>(string id) where T : BaseApiBean
        {
            var path = GetPathFromType<T>();
            return await GetAsync<T>($"{BaseUrl}{path}/{id}");
        }

        /// <inheritdoc/>
        public async Task<T?> GetListAsync<T>(string? searchCriteria = null, string? path = null) where T : class
        {
            try
            {
                if (string.IsNullOrEmpty(path))
                {
                    path = GetPathFromType<T>();
                }

                var url = $"{BaseUrl}{path}"
                    + (string.IsNullOrWhiteSpace(searchCriteria)
                        ? $"?resultsPerPage={MaxResults}"
                        : $"?q={Uri.EscapeDataString(searchCriteria)}&resultsPerPage={MaxResults}");

                var response = await httpClient.GetAsync(url);
                _ = response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();

                return DeserializeXml<T>(content);
            }
            catch (HttpRequestException ex)
            {
                throw new ApiException($"HTTP request failed: {ex.Message}");
            }
        }

        /// <inheritdoc/>
		public async Task<HttpResponseMessage> UpdateAsync(BaseApiBean bean)
        {
            try
            {
                var xmlContent = SerializeXml(bean);
                var content = new StringContent(xmlContent, Encoding.UTF8, "application/xml");

                var response = await httpClient.PutAsync(bean.RefURL, content);

                if (response.StatusCode is not System.Net.HttpStatusCode.OK
                    and not System.Net.HttpStatusCode.Created
                    and not System.Net.HttpStatusCode.Accepted)
                {
                    await HandleErrorsAsync(response);
                }

                return response;
            }
            catch (HttpRequestException ex)
            {
                throw new ApiException($"HTTP request failed: {ex.Message}");
            }
        }

        /// <inheritdoc/>
		public async Task<T?> UpdateAndGetBeanAsync<T>(T bean) where T : BaseApiBean
        {
            _ = await UpdateAsync(bean);
            return await GetAsync<T>(bean.RefURL!);
        }

        private async Task HandleErrorsAsync(HttpResponseMessage response)
        {
            var responseText = await response.Content.ReadAsStringAsync();

            if (!string.IsNullOrWhiteSpace(responseText))
            {
                try
                {
                    var errors = DeserializeXml<ApiErrors>(responseText);
                    if (errors != null)
                    {
                        throw new ApiException(errors);
                    }
                }
                catch (Exception)
                {
                    throw new ApiException(responseText);
                }
            }
            else
            {
                throw new ApiException($"{(int)response.StatusCode} {response.ReasonPhrase}");
            }
        }

        private string? GetLocationFromResponse(HttpResponseMessage response)
        {
            if (response.Headers.Location != null)
            {
                return response.Headers.Location.PathAndQuery;
            }

            return null;
        }

        private string GetPathFromType<T>()
        {
            // In C# we would typically use attributes or a mapping dictionary. Returning a simple default for now.
            return typeof(T).Name.ToLower();
        }

        private string SerializeXml<T>(T obj)
        {
            var serializer = new XmlSerializer(typeof(T));
            using var stringWriter = new StringWriter();
            serializer.Serialize(stringWriter, obj);
            return stringWriter.ToString();
        }

        private T? DeserializeXml<T>(string xml)
        {
            var serializer = new XmlSerializer(typeof(T));
            using var stringReader = new StringReader(xml);
            return (T?)serializer.Deserialize(stringReader);
        }
    }
}
