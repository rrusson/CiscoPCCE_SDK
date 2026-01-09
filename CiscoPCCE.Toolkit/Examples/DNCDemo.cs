using CiscoPCCE.Toolkit.Bean;

namespace CiscoPCCE.Toolkit.Examples
{
    /// <summary>
    /// Example code for Do Not Call ImportRule operations.
    /// </summary>
    public class DNCDemo
    {
        private const string DncNamePrefix = "DemoDNC";
        private const string DncServiceName = "dnc";

        /// <summary>
        /// Launches the DNCDemo if arguments are valid.
        /// </summary>
        public static async Task Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("DNCDemo requires 3 arguments: hostname username (with @domain) password");
                Environment.Exit(0);
            }

            // Create a new RESTClient object with the IP of you DS / AW HDS
            var restClient = new RESTClient(args[0], args[1], args[2]);

            var deploymentType = await restClient.GetAsync<Deployment>(RESTClient.BaseUrl + "deployment");

            Console.WriteLine($"System is in Deployment Type: {deploymentType?.DeploymentType}");

            try
            {
                await DncDemoAsync(restClient, args[0]);
            }
            catch (ApiException e)
            {
                Console.WriteLine(e.Errors);
            }
        }

        /// <summary>
        /// This function demonstrates the various operations allowed on the DNC API
        /// 1. Creates a new Do Not Call Import Rule
        /// 2. Updates the DNC
        /// 3. Deletes the DNC
        /// The list operation is similar to the Campaign, Please refer to the CampaignDemo
        /// </summary>
        private static async Task DncDemoAsync(RESTClient restClient, string hostname)
        {
            //Create the new DNC Import Rule
            var dnc1 = await CreateAndGetDNCAsync(restClient, hostname);

            //Update the DNC - setting overwriteEnabled to true
            await UpdateAndVerifyDNCAsync(restClient, dnc1);

            //Delete the DNC Import Rule
            DeleteDNC(restClient, dnc1);
        }

        /// <summary>
        /// This function deletes the DNC Import Rule
        /// </summary>
        private static async void DeleteDNC(RESTClient restClient, ImportRule? dnc)
        {
            if (dnc?.RefURL != null)
            {
                await restClient.DeleteAsync(dnc.RefURL);
                Console.WriteLine($"deleted {dnc.GetType().Name}: {dnc.RefURL}");
            }
        }

        /// <summary>
        /// Creates the DNC Import Rule and returns it
        /// </summary>
        private static async Task<ImportRule?> CreateAndGetDNCAsync(RESTClient restClient, string hostname)
        {
            var filePath = $"\\\\{hostname}\\C$\\dnc.txt";
            //Populate the Bean
            var dnc = PopulateDNCBean(DemoUtils.GenerateUniqueString(DncNamePrefix, 1), filePath, false, false);

            //Create the DNC
            var refUrl = await restClient.CreateAndGetAsync(dnc, DncServiceName);
            ImportRule? dncResult = null;
            if (refUrl != null)
            {
                dncResult = await restClient.GetAsync<ImportRule>(refUrl);
                Console.WriteLine($"DNC Rule Created: {dncResult?.RefURL}");
            }
            return dncResult;
        }

        /// <summary>
        /// This function populates the DNC Import Rule Bean with the values
        /// </summary>
        /// <param name="dncName">Name of the Do Not Call Rule</param>
        /// <param name="filePath">Path to the import file which is on logger or accessible from logger</param>
        /// <param name="overwriteEnabled">If the new import should override the numbers that got imported with a previous import</param>
        /// <param name="renameEnabled">If the DNC import file will be renamed after import is complete, else file will be deleted</param>
        private static ImportRule PopulateDNCBean(string dncName, string filePath, bool overwriteEnabled, bool renameEnabled)
        {
            var dnc = new ImportRule
            {
                Name = dncName,
                FilePath = filePath,
                OverwriteEnabled = overwriteEnabled,
                RenameEnabled = renameEnabled
            };
            return dnc;
        }

        /// <summary>
        /// This function updates the DNC Import Rule with overwriteEnabled to true
        /// </summary>
        private static async Task UpdateAndVerifyDNCAsync(RESTClient restClient, ImportRule? dnc)
        {
            if (dnc == null) return;

            Console.WriteLine("Updating DNC, setting overwriteEnabled = true");
            Console.WriteLine($"overwriteEnabled before update: {dnc.OverwriteEnabled}");

            dnc.OverwriteEnabled = true;
            var updateDNC = await restClient.UpdateAndGetBeanAsync(dnc);

            Console.WriteLine($"DNC updated: {updateDNC?.RefURL}");
            Console.WriteLine($"overwriteEnabled after update: {updateDNC?.OverwriteEnabled}");
        }
    }
}
