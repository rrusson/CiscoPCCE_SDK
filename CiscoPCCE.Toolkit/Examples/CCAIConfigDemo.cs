namespace CiscoPCCE.Toolkit.Examples
{
    /// <summary>
    /// Example code for retrieving and syncing CCAI config.
    /// </summary>
    public class CcaiConfigDemo
    {
        private static RestClient? restClient = null;

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

            restClient = new RestClient(args[0], args[1], args[2]);
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
                // Note: This would ideally use the RESTClient's HttpClient instance for proper authentication
                // For sync operations that don't require a bean, the Java version uses a different method
                // In a production implementation, this should use the authenticated HttpClient from RESTClient
                Console.WriteLine("CCAI Global Config sync - Note: Implementation requires authenticated HTTP client");
                Console.WriteLine("This is a placeholder showing the structure. Actual implementation would need");
                Console.WriteLine("to extend RESTClient to support POST operations without a bean parameter.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"CCAI Global Config sync failed. Error: {e.Message}");
            }
        }
    }
}
