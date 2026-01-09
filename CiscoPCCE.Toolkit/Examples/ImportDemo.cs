using CiscoPCCE.Toolkit.Bean;

namespace CiscoPCCE.Toolkit.Examples
{
    /// <summary>
    /// Example code for importing customer contact records for a Campaign.
    /// </summary>
    public class ImportDemo
    {
        private static RESTClient? restClient = null;
        private static SkillGroup? skillGroup = null;
        private static bool skillGroupCreated = false;

        private static readonly string CommaSeparatedFileContentMultipleFields =
            "AccountNumber,FirstName,LastName,Phone01,Phone02" + DemoUtils.NewLine +
            "ACCOUNT111,Mir,Ali,123456789,987654321" + DemoUtils.NewLine +
            "ACCOUNT112,Steve,Glovin,123456788,9876543*22" + DemoUtils.NewLine +
            "ACCOUNT113,Tom,Weissinger,123456787,987654323#" + DemoUtils.NewLine +
            "ACCOUNT114,Sajith,Kaimal,123456786,9*87654324";

        private static readonly string PipeSeparatedFileContentMultipleFields =
            "AccountNumber|FirstName|LastName|Phone01|Phone02" + DemoUtils.NewLine +
            "ACCOUNT115|Mark|Rzasa|123456789|987654321" + DemoUtils.NewLine +
            "ACCOUNT116|Elie|Lalo|123456788|9876543*22" + DemoUtils.NewLine +
            "ACCOUNT117|Josephine|Zhuang|123456787|987654323#" + DemoUtils.NewLine +
            "ACCOUNT118|Avinash|Kumar|123456786|9*87654324";

        private const string ImportPath = "import";

        /// <summary>
        /// Launches the ImportDemo if the arguments are valid.
        /// </summary>
        public static async Task Main(string[] args)
        {
            await ValidateAndSetupSkillGroupAsync(args);

            if (restClient != null)
            {
                await ImportDemoAsync(restClient);
            }
        }

        /// <summary>
        /// This function demonstrates the Create and Delete operations on Campaign import records
        /// Steps:
        /// 1. Create a Campaign
        /// 2. Import four records using comma-delimited values
        /// 3. Import four more records using pipe-delimited values
        /// 4. Delete the imported records, campaign and skillGroup.
        /// </summary>
        private static async Task ImportDemoAsync(RESTClient restClient)
        {
            Campaign? campaign = null;

            try
            {
                // -- Create a Campaign
                campaign = await CampaignDemo.CreateAndGetCampaignAsync(restClient, skillGroup);

                if (campaign != null)
                {
                    var importPath = ConstructImportPath(campaign);

                    // -- Create 4 records using comma-delimited file content
                    await restClient.CreateAsync(PopulateBulkImportBean(DemoUtils.CommaDelimiter, CommaSeparatedFileContentMultipleFields, false),
                        importPath);
                    Console.WriteLine("Created Import with 4 records comma-separated");

                    // -- Create 4 more records using pipe-delimited file content
                    await restClient.CreateAsync(PopulateBulkImportBean(DemoUtils.PipeDelimiter, PipeSeparatedFileContentMultipleFields, false),
                        importPath);
                    Console.WriteLine("Created Import with 4 more records pipe-separated");
                }
            }
            catch (ApiException e)
            {
                Console.WriteLine(e.Errors);
            }
            finally
            {
                // Deleting import, campaign and skillGroup
                if (campaign?.RefURL != null)
                {
                    await restClient.DeleteAsync(campaign.RefURL + "/import");
                    Console.WriteLine("Deleted all imported records");
                    await restClient.DeleteAsync(campaign.RefURL);
                    Console.WriteLine("Deleted Campaign");
                }
                if (skillGroupCreated && skillGroup?.RefURL != null)
                {
                    await restClient.DeleteAsync(skillGroup.RefURL);
                    Console.WriteLine("Deleted SkillGroup");
                }
            }
        }

        /// <summary>
        /// Construct import path from Campaign refURL
        /// </summary>
        private static string ConstructImportPath(Campaign campaign)
        {
            var importPath = campaign.RefURL?.Replace(RESTClient.BaseUrl, "") ?? "";
            importPath += "/" + ImportPath;
            return importPath;
        }

        /// <summary>
        /// Create and return an Import Bean
        /// </summary>
        /// <param name="delimiter">Delimiter used in file content</param>
        /// <param name="fileContent">Records to be imported including the header</param>
        /// <param name="overwriteData">if existing data should be overwritten</param>
        private static ImportContact PopulateBulkImportBean(string delimiter, string fileContent, bool overwriteData)
        {
            var importContact = new ImportContact
            {
                Delimiter = delimiter,
                FileContent = fileContent,
                OverwriteData = overwriteData
            };

            return importContact;
        }

        /// <summary>
        /// Validates the arguments based on deployment type
        /// Sets up the Skill Groups
        /// </summary>
        private static async Task ValidateAndSetupSkillGroupAsync(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("ImportDemo requires at least 3 arguments: hostname username(with @domain) password");
                Environment.Exit(0);
            }

            // Create a new RESTClient object with the IP of you DS / AW HDS
            restClient = new RESTClient(args[0], args[1], args[2]);

            var deploymentType = await restClient.GetAsync<Deployment>(RESTClient.BaseUrl + "deployment");
            Console.WriteLine($"System is in Deployment Type: {deploymentType?.DeploymentType}");

            if (!DemoUtils.IsPCCEDeploymentType(deploymentType) && args.Length < 4)
            {
                Console.WriteLine("ImportDemo requires 4 arguments in non-PCCE deployments: " +
                        "hostname username(with @domain) password skillGroupName");
                Environment.Exit(0);
            }
            else if (!DemoUtils.IsPCCEDeploymentType(deploymentType))
            {
                var skillGroupBase = await DemoUtils.LookupSkillGroupAsync(restClient, args[3]);
                // Get the full SkillGroup object
                if (skillGroupBase?.RefURL != null)
                {
                    skillGroup = await restClient.GetAsync<SkillGroup>(skillGroupBase.RefURL);
                }
            }

            if (DemoUtils.IsPCCEDeploymentType(deploymentType))
            {
                if (args.Length < 4)
                {
                    skillGroup = await CampaignDemo.CreateAndGetSkillGroupAsync(restClient);
                    skillGroupCreated = true;
                }
                else
                {
                    var skillGroupBase = await DemoUtils.LookupSkillGroupAsync(restClient, args[3]);
                    // Get the full SkillGroup object
                    if (skillGroupBase?.RefURL != null)
                    {
                        skillGroup = await restClient.GetAsync<SkillGroup>(skillGroupBase.RefURL);
                    }
                }

                if (skillGroup == null)
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
