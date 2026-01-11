using CiscoPCCE.Toolkit.Bean;
using CiscoPCCE.Toolkit.Sdk;
using CiscoPCCE.Toolkit.Sdk.Helpers;

namespace CiscoPCCE.Toolkit.Examples
{
    /// <summary>
    /// Example code for Campaign operations.
    /// </summary>
    public class CampaignDemo
    {
        private static RestClient? restClient = null;
        private static SkillGroup? skillGroup1 = null;
        private static SkillGroup? skillGroup2 = null;
        private static bool skillGroupsCreated = false;

        private static int campaignCount = 1;
        private static int skillGroupCount = 1;

        private const string CampaignNamePrefix = "DemoCampaign";

        /// <summary>
        /// Validates the arguments
        /// Sets up the SkillGroups
        /// Launches the campaignDemo
        /// </summary>
        public static async Task Main(string[] args)
        {
            await ValidateAndSetupSkillGroupsAsync(args);

            if (restClient != null)
            {
                await CampaignDemoAsync(restClient);
            }
        }

        /// <summary>
        /// This function demonstrates the various operations allowed on a Campaign
        /// Steps:
        /// 1. Create the Campaign
        /// 2. Update a value in the Campaign and verify that it is updated.
        /// 3. Create one more Campaigns.
        /// 4. Get a list of Campaigns created (2 in all)
        /// 5. Delete all the Campaigns and SkillGroups created.
        /// 6. Getting a Campaign with an non-existing CampaignID will result in an error. This shows the format of errors.
        /// </summary>
        private static async Task CampaignDemoAsync(RestClient restClient)
        {
            Campaign? campaign1 = null;
            Campaign? campaign2 = null;

            try
            {
                // -- Create a Campaign
                campaign1 = await CreateAndGetCampaignAsync(restClient, skillGroup1);

                // -- Update the campaign - set abandonEnabled to false
                await UpdateAndVerifyCampaignAsync(restClient, campaign1);

                // -- Create 1 more Campaign
                campaign2 = await CreateAndGetCampaignAsync(restClient, skillGroup2);

                // Get the list of the Campaigns created
                var campaigns = await restClient.GetListAsync<CampaignList>(CampaignNamePrefix);
                Console.WriteLine($"Number of Campaigns retrieved on LIST: {campaigns?.Items?.Count ?? 0}");
            }
            catch (ApiException e)
            {
                Console.WriteLine(e.Errors);
            }
            finally
            {
                // *** Finally Delete everything
                if (campaign1?.RefURL != null)
                {
                    await restClient.DeleteAsync(campaign1.RefURL);
                    Console.WriteLine($"Deleted Campaign: {campaign1.RefURL}");
                }
                if (campaign2?.RefURL != null)
                {
                    await restClient.DeleteAsync(campaign2.RefURL);
                    Console.WriteLine($"Deleted Campaign: {campaign2.RefURL}");
                }
                if (skillGroupsCreated)
                {
                    if (skillGroup1?.RefURL != null)
                    {
                        await restClient.DeleteAsync(skillGroup1.RefURL);
                    }
                    if (skillGroup2?.RefURL != null)
                    {
                        await restClient.DeleteAsync(skillGroup2.RefURL);
                    }
                    Console.WriteLine("Deleted SkillGroups.");
                }
            }

            // -- Try and get a Campaign that doesn't exist
            await CheckingGetOnNonExistingCampaignAsync(restClient);
        }

        /// <summary>
        /// Creates a Campaign and returns the created Campaign
        /// </summary>
        /// <param name="restClient">Rest Client</param>
        /// <param name="skillGroup">SkillGroup - a SkillGroup is required for creating a Campaign, this skillGroup must not be used in other Campaigns</param>
        public static async Task<Campaign?> CreateAndGetCampaignAsync(RestClient restClient, SkillGroup? skillGroup)
        {
            if (skillGroup == null)
            {
                return null;
            }

            var skillGroupInfos = CreateCampaignSkillGroupInfos(new List<SkillGroup> { skillGroup });

            // -- Get UTC timeZone
            var timeZoneUTC = await restClient.GetAsync<Bean.TimeZone>(RestClient.BaseUrl + "timezone/UTC");

            // -- Make a new Campaign object
            var campaign = PopulateCampaignBean(DemoUtils.GenerateUniqueString(CampaignNamePrefix, campaignCount++),
                                                DialingMode.PREVIEWONLY, skillGroupInfos, timeZoneUTC);

            var refUrl = await restClient.CreateAndGetAsync(campaign);
            Campaign? result = null;
            if (refUrl != null)
            {
                result = await restClient.GetAsync<Campaign>(refUrl);
                Console.WriteLine($"Campaign created: {result?.RefURL}");
            }
            return result;
        }

        /// <summary>
        /// Creates a SkillGroup and returns the created SkillGroup
        /// </summary>
        public static async Task<SkillGroup?> CreateAndGetSkillGroupAsync(RestClient restClient)
        {
            var skillGroup = new SkillGroup
            {
                Name = DemoUtils.GenerateUniqueString("skill", skillGroupCount++),
                Datacenter = new ReferenceBean(),
                Department = new ReferenceBean(),
                Peripheral = new PeripheralRef(),
                PeripheralSet = new ReferenceBean(),
                BucketInterval = new ReferenceBean(),
                CampaignRef = new ReferenceBean(),
                MediaRoutingDomain = new ReferenceBean()
            };

            var refUrl = await restClient.CreateAndGetAsync(skillGroup);
            SkillGroup? result = null;
            if (refUrl != null)
            {
                result = await restClient.GetAsync<SkillGroup>(refUrl);
                Console.WriteLine($"Skill Group created: {result?.RefURL}");
            }
            return result;
        }

        /// <summary>
        /// Updates the Campaign by changing the value of abandonEnabled from true to false.
        /// Prints out the value of abandonEnabled before and after update.
        /// </summary>
        private static async Task UpdateAndVerifyCampaignAsync(RestClient restClient, Campaign? campaign)
        {
            if (campaign == null)
            {
                return;
            }

            Console.WriteLine("Updating Campaign, setting abandonEnabled to false");
            Console.WriteLine($"abandonEnabled before update: {campaign.AbandonEnabled}");

            campaign.AbandonEnabled = false;
            var updateCampaign = await restClient.UpdateAndGetBeanAsync(campaign);
            Console.WriteLine($"Campaign updated: {updateCampaign?.RefURL}");
            Console.WriteLine($"abandonEnabled after update: {updateCampaign?.AbandonEnabled}");
        }

        /// <summary>
        /// This function calls the GET method on a non-existing Campaign i.e. campaign refURL has an invalid id.
        /// Also prints out the Error message received on standard output
        /// </summary>
        private static async Task CheckingGetOnNonExistingCampaignAsync(RestClient restClient)
        {
            Console.WriteLine("Getting a non-existing campaign should return an error");
            try
            {
                _ = await restClient.GetAsync<Campaign>(RestClient.BaseUrl + "campaign/12345");
            }
            catch (ApiException e)
            {
                if (e.Errors != null)
                {
                    Console.WriteLine(e.Errors.ToString());
                }
                else
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        /// <summary>
        /// Creates a list of CampaignSkillGroupInfos from the list of SkillGroups provided
        /// </summary>
        private static List<CampaignSkillGroupInfo> CreateCampaignSkillGroupInfos(List<SkillGroup> skillGroups)
        {
            var skillGroupInfos = new List<CampaignSkillGroupInfo>(skillGroups.Count);

            foreach (var skillGroup in skillGroups)
            {
                // -- Setup a SkillGroupInfo for the SkillGroup
                var skillGroupInfo = new CampaignSkillGroupInfo
                {
                    SkillGroupRef = new ReferenceBean
                    {
                        Name = skillGroup.Name,
                        RefURL = skillGroup.RefURL
                    }
                };

                // Add SkillGroupInfo to SkillGroupInfos
                skillGroupInfos.Add(skillGroupInfo);
            }

            return skillGroupInfos;
        }

        /// <summary>
        /// Create and return a Campaign bean
        /// </summary>
        /// <param name="campaignName">Name of the Campaign</param>
        /// <param name="dialingMode">Campaign's dialing mode</param>
        /// <param name="skillGroupInfos">List of SkillGroupInfos</param>
        /// <param name="timeZone">Default TimeZone of the Campaign</param>
        private static Campaign PopulateCampaignBean(string campaignName,
                                                     DialingMode dialingMode,
                                                     List<CampaignSkillGroupInfo> skillGroupInfos,
                                                     Bean.TimeZone? timeZone)
        {
            var newCampaign = new Campaign
            {
                Name = campaignName,
                DialingMode = dialingMode,
                SkillGroupInfos = skillGroupInfos,
                TimeZone = new TimeZoneRef
                {
                    RefURL = timeZone?.RefURL,
                    DisplayName = timeZone?.Name
                },
                CpaFields = new CampaignCPAFields(),
                Department = new ReferenceBean(),
                ImportContact = new ImportContact(),
                Retries = new CampaignRetryFields()
            };

            return newCampaign;
        }

        /// <summary>
        /// Creates SkillGroups and sets them up.
        /// </summary>
        private static async Task CreateAndSetSkillGroupsAsync(RestClient restClient)
        {
            skillGroup1 = await CreateAndGetSkillGroupAsync(restClient);
            skillGroup2 = await CreateAndGetSkillGroupAsync(restClient);

            skillGroupsCreated = true;
        }

        /// <summary>
        /// Looks up the Skill Groups by skill group names and sets them up.
        /// Prints errors to standard output and exits if SkillGroups cannot be created
        /// </summary>
        private static async Task LookupAndSetSkillGroupsAsync(RestClient restClient, string skillGroupName1, string skillGroupName2)
        {
            var skillGroupBase1 = await DemoUtils.LookupSkillGroupAsync(restClient, skillGroupName1);
            var skillGroupBase2 = await DemoUtils.LookupSkillGroupAsync(restClient, skillGroupName2);

            // Get the full SkillGroup objects
            if (skillGroupBase1?.RefURL != null)
            {
                skillGroup1 = await restClient.GetAsync<SkillGroup>(skillGroupBase1.RefURL);
            }
            if (skillGroupBase2?.RefURL != null)
            {
                skillGroup2 = await restClient.GetAsync<SkillGroup>(skillGroupBase2.RefURL);
            }

            if (skillGroup1 == null || skillGroup2 == null)
            {
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// Validates the arguments based on deployment type
        /// Sets up the Skill Groups
        /// </summary>
        private static async Task ValidateAndSetupSkillGroupsAsync(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("CampaignDemo requires at least 3 arguments: hostname username(with @domain) password");
                Environment.Exit(0);
            }

            // Create a new RESTClient object with the IP of you DS / AW HDS
            restClient = new RestClient(args[0], args[1], args[2]);

            var deploymentType = await restClient.GetAsync<Deployment>(RestClient.BaseUrl + "deployment");
            Console.WriteLine($"System is in Deployment Type: {deploymentType?.DeploymentType}");

            if (!DemoUtils.IsPCCEDeploymentType(deploymentType) && args.Length < 5)
            {
                Console.WriteLine("CampaignDemo requires 5 arguments in non-PCCE deployments: " +
                        "hostname username(with @domain) password skillGroupName1 skillGroupName2");
                Environment.Exit(0);
            }
            else if (!DemoUtils.IsPCCEDeploymentType(deploymentType))
            {
                await LookupAndSetSkillGroupsAsync(restClient, args[3], args[4]);
            }

            if (DemoUtils.IsPCCEDeploymentType(deploymentType))
            {
                if (args.Length < 5)
                {
                    await CreateAndSetSkillGroupsAsync(restClient);
                }
                else
                {
                    await LookupAndSetSkillGroupsAsync(restClient, args[3], args[4]);
                }
            }
        }
    }
}
