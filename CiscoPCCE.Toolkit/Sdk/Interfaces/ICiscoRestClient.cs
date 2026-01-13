namespace CiscoPCCE.Toolkit.Sdk.Interfaces
{
	public interface ICiscoRestClient
	{
		Task<string?> CreateAndGetAsync<T>(T bean) where T : BaseApiBean;
		Task<string?> CreateAndGetAsync<T>(T bean, string? path) where T : BaseApiBean;
		Task<HttpResponseMessage> CreateAsync<T>(T bean) where T : BaseApiBean;
		Task<HttpResponseMessage> CreateAsync<T>(T bean, string? path) where T : BaseApiBean;
		Task DeleteAsync(string refURL);
		Task DeleteByIdAsync<T>(string id) where T : BaseApiBean;
		Task<T?> GetAsync<T>(string refURL) where T : BaseApiBean;
		Task<T?> GetByIdAsync<T>(string id) where T : BaseApiBean;
		Task<T?> GetListAsync<T>() where T : class;
		Task<T?> GetListAsync<T>(string? searchCriteria) where T : class;
		Task<T?> GetListAsync<T>(string? searchCriteria, string? path) where T : class;
		Task<T?> UpdateAndGetBeanAsync<T>(T bean) where T : BaseApiBean;
		Task<HttpResponseMessage> UpdateAsync(BaseApiBean bean);
	}
}