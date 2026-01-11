using System.Net.Http.Headers;
using System.Text;
using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk.Helpers;
using CiscoPCCE.Toolkit.Sdk.Interfaces;

namespace CiscoPCCE.Toolkit.Sdk
{
	/// <summary>
	/// A simple SSL REST Client wrapper to handle CRUD API calls to Cisco services
	/// </summary>
	public class RestClient : IRestClient
	{
		/// <summary>
		/// Base URL for the Cisco PCCE API
		/// </summary>
		public const string BaseUrl = "/unifiedconfig/config/";

		/// <summary>
		/// HTTP Client for handling CRUD calls
		/// </summary>
		private readonly HttpClient httpClient;

		/// <summary>
		/// Parameterized Constructor
		/// </summary>
		/// <param name="hostName">Fully qualified host name or IP</param>
		/// <param name="username">Fully qualified username (with @domain)</param>
		/// <param name="password">User's password</param>
		public RestClient(string hostName, string username, string password)
		{
			// Create HTTP client handler that accepts all SSL certificates
			var handler = new HttpClientHandler
			{
				ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true,
				SslProtocols = System.Security.Authentication.SslProtocols.Tls12
			};

			httpClient = new HttpClient(handler)
			{
				BaseAddress = new Uri($"https://{hostName}")
			};

			// Add basic authentication
			var authToken = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{password}"));
			httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authToken);
		}

		/// <summary>
		/// Returns an object of the passed in class type by ID.
		/// </summary>
		/// <typeparam name="T">Type of object to get back</typeparam>
		/// <param name="refURL">Relative URL to the object</param>
		/// <returns>Object of the bean type with the id</returns>
		public async Task<T?> GetAsync<T>(string refURL) where T : BaseApiBean
		{
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

		/// <summary>
		/// Returns the object with the specified ID.
		/// </summary>
		public async Task<T?> GetByIdAsync<T>(string id) where T : BaseApiBean
		{
			var path = GetPathFromType<T>();
			return await GetAsync<T>($"{BaseUrl}{path}/{id}");
		}

		/// <summary>
		/// Deletes an object of the bean type with the id.
		/// </summary>
		/// <param name="refURL">Relative URL of the object to delete</param>
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

		/// <summary>
		/// Deletes the object with the specified ID.
		/// </summary>
		public async Task DeleteByIdAsync<T>(string id) where T : BaseApiBean
		{
			var path = GetPathFromType<T>();
			await DeleteAsync($"{BaseUrl}{path}/{id}");
		}

		/// <summary>
		/// Returns a list bean object matching the bean type containing zero or more items.
		/// </summary>
		public async Task<T?> GetListAsync<T>() where T : class
		{
			return await GetListAsync<T>(null);
		}

		/// <summary>
		/// Returns a list bean object matching the bean type containing zero or more items.
		/// </summary>
		/// <param name="searchCriteria">Search parameter (ignored if null)</param>
		public async Task<T?> GetListAsync<T>(string? searchCriteria) where T : class
		{
			return await GetListAsync<T>(searchCriteria, null);
		}

		/// <summary>
		/// Returns a list bean object matching the bean type containing zero or more items with a custom path to the service.
		/// </summary>
		/// <param name="searchCriteria">Search parameter (ignored if null)</param>
		/// <param name="path">Customized path to the service - eg campaign/{id}/import</param>
		public async Task<T?> GetListAsync<T>(string? searchCriteria, string? path) where T : class
		{
			try
			{
				if (string.IsNullOrEmpty(path))
				{
					path = GetPathFromType<T>();
				}

				var url = $"{BaseUrl}{path}";
				if (!string.IsNullOrWhiteSpace(searchCriteria))
				{
					url += $"?q={Uri.EscapeDataString(searchCriteria)}";
				}

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

		/// <summary>
		/// Make a post request to the bean's API. i.e. if the bean is Agent, attempts to create an agent.
		/// </summary>
		/// <param name="bean">Bean to create</param>
		public async Task<HttpResponseMessage> CreateAsync<T>(T bean) where T : BaseApiBean
		{
			return await CreateAsync(bean, null);
		}

		/// <summary>
		/// Make a post request to the bean's API.
		/// </summary>
		/// <param name="bean">Bean to create</param>
		/// <param name="path">Path to the service</param>
		public async Task<HttpResponseMessage> CreateAsync<T>(T bean, string? path) where T : BaseApiBean
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

		/// <summary>
		/// Makes a post request and returns the newly created object's ID.
		/// </summary>
		public async Task<string?> CreateAndGetAsync<T>(T bean) where T : BaseApiBean
		{
			return await CreateAndGetAsync(bean, null);
		}

		/// <summary>
		/// Makes a post request with the custom path (if available) and returns the newly created object's ID.
		/// </summary>
		public async Task<string?> CreateAndGetAsync<T>(T bean, string? path) where T : BaseApiBean
		{
			var response = string.IsNullOrWhiteSpace(path) ? await CreateAsync(bean) : await CreateAsync(bean, path);
			return GetLocationFromResponse(response);
		}

		/// <summary>
		/// Makes a put request to update the object with the values in the bean.
		/// </summary>
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

		/// <summary>
		/// Makes a put request to update the object and then performs a get on the object.
		/// </summary>
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
