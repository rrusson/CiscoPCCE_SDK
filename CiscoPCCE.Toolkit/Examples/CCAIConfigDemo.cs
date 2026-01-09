namespace CiscoPCCE.Toolkit.Examples
{
    /// <summary>
    /// Example code for retrieving and syncing CCAI config.
    /// 
    /// Command line launch: dotnet run CCAIConfigDemo hostname username password
    /// </summary>
    public class CCAIConfigDemo
    {
        private static RESTClient? restClient = null;

        public static async Task Main(string[] args)
        {
            // Create a new RESTClient object
            //args[0] - IP of AW-HDS
            //args[1] - user name(with domain)
            //args[2] - password
            if (args.Length < 3)
            {
                Console.WriteLine("CCAIConfigDemo requires 3 parameters: hostname username (with @domain) password");
                Environment.Exit(0);
            }

            restClient = new RESTClient(args[0], args[1], args[2]);
            await DemoCCAIConfigAsync();
        }

        private static async Task DemoCCAIConfigAsync()
        {
            await GetCCAIConfigAsync();
            await GetGlobalCCAIConfigAsync();
            await SyncGlobalCCAIConfigAsync();
        }

        private static async Task GetCCAIConfigAsync()
        {
            try
            {
                var ccaiConfig = await restClient!.GetListAsync<object>("contactcenterai/config");
                Console.WriteLine("****************************************************************************************************");
                Console.WriteLine("****************************************************************************************************");
                Console.WriteLine($"CCAI Config list: {ccaiConfig}");
            }
            catch (ApiException e)
            {
                Console.WriteLine($"CCAI Config list fetch failed. Errors: {e.Errors}");
            }
        }

        private static async Task GetGlobalCCAIConfigAsync()
        {
            try
            {
                Console.WriteLine("****************************************************************************************************");
                Console.WriteLine("****************************************************************************************************");
                var ccaiGlobalConfig = await restClient!.GetListAsync<object>("contactcenterai/globalconfig");
                Console.WriteLine($"CCAI Global Config list: {ccaiGlobalConfig}");
            }
            catch (ApiException e)
            {
                Console.WriteLine($"CCAI Global Config list fetch failed. Errors: {e.Errors}");
            }
        }

        private static async Task SyncGlobalCCAIConfigAsync()
        {
            try
            {
                Console.WriteLine("****************************************************************************************************");
                Console.WriteLine("****************************************************************************************************");
                // For sync operations that don't require a bean, we just need to POST to the endpoint
                // The simplest approach is to use HttpClient directly for this edge case
                var httpClient = new System.Net.Http.HttpClient();
                var response = await httpClient.PostAsync($"{RESTClient.BaseUrl}contactcenterai/globalconfig/sync", null);
                Console.WriteLine($"CCAI Global Config sync is successful. Response status: {response.StatusCode}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"CCAI Global Config sync failed. Error: {e.Message}");
            }
        }
    }
}
