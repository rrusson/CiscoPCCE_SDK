namespace CiscoPCCE.Toolkit.Sdk.Interfaces
{
	public interface ICiscoRestClient
	{
        /// <summary>
        /// Maximum number of result records to return
        /// </summary>
        int MaxResults { get; set; }

        /// <summary>
        /// Make a post request to the bean's API.
        /// </summary>
        /// <param name="bean">Bean to create</param>
        /// <param name="path">Path to the service</param>
		Task<HttpResponseMessage> CreateAsync<T>(T bean, string? path = null) where T : BaseApiBean;

        /// <summary>
        /// Makes a post request with the custom path (if available) and returns the newly created object's ID.
        /// </summary>
        Task<string?> CreateAndGetAsync<T>(T bean, string? path = null) where T : BaseApiBean;

        /// <summary>
        /// Deletes an object of the bean type with the id.
        /// </summary>
        /// <param name="refURL">Relative URL of the object to delete</param>
        Task DeleteAsync(string refURL);

        /// <summary>
        /// Deletes the object with the specified ID.
        /// </summary>
        Task DeleteByIdAsync<T>(string id) where T : BaseApiBean;

        /// <summary>
        /// Returns an object of the passed in class type by ID.
        /// </summary>
        /// <typeparam name="T">Type of object to get back</typeparam>
        /// <param name="refURL">Relative URL to the object</param>
        /// <returns>Object of the bean type with the id</returns>
        Task<T?> GetAsync<T>(string refURL) where T : BaseApiBean;

        /// <summary>
        /// Returns the object with the specified ID.
        /// </summary>
        Task<T?> GetByIdAsync<T>(string id) where T : BaseApiBean;

        /// <summary>
        /// Returns a <typeparamref name="T"/> containing zero or more items with a custom path to the service.
        /// </summary>
        /// <param name="searchCriteria">Optional search parameter</param>
        /// <param name="path">Optional customized path to the service (e.g. "campaign/{id}/import")</param>
        Task<T?> GetListAsync<T>(string? searchCriteria = null, string? path = null) where T : class;

        /// <summary>
        /// Makes a put request to update the object with the values in the bean.
        /// </summary>
        Task<HttpResponseMessage> UpdateAsync(BaseApiBean bean);

        /// <summary>
        /// Makes a put request to update the object and then performs a get on the object.
        /// </summary>
        Task<T?> UpdateAndGetBeanAsync<T>(T bean) where T : BaseApiBean;
    }
}