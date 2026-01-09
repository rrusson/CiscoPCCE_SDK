using CiscoPCCE.Toolkit.Bean;

namespace CiscoPCCE.Toolkit.Examples
{
    /// <summary>
    /// Example code for Personal Callback Operations.
    /// </summary>
    public class PersonalCallbackDemo
    {
        private static RestClient? restClient = null;
        private static Agent? agent = null;
        private static bool agentCreated = false;

        /// <summary>
        /// Launches the PersonalCallbackDemo if the arguments are valid.
        /// </summary>
        public static async Task Main(string[] args)
        {
            await ValidateAndSetupAgentAsync(args);

            if (restClient != null)
            {
                await PersonalCallbackDemoAsync(restClient);
            }
        }

        /// <summary>
        /// This function demonstrates the Create and Delete operations on Personal Callback records
        /// Steps:
        /// 1. Create a PersonalCallback Record
        /// 2. Delete the Agent and Personal Callback records
        /// </summary>
        private static async Task PersonalCallbackDemoAsync(RestClient restClient)
        {
            PersonalCallbackRecord? pcbRecord = null;

            try
            {
                // -- Create a PersonalCallback Record
                pcbRecord = await CreatePersonalCallbackRecordAsync(restClient, agent);
            }
            catch (ApiException e)
            {
                Console.WriteLine(e.Errors);
            }
            finally
            {
                // Deleting Agent and Personal Callback records
                if (agentCreated && agent?.RefURL != null)
                {
                    await restClient.DeleteAsync(agent.RefURL);
                    Console.WriteLine("Agent Deleted.");
                }
                if (pcbRecord?.RefURL != null)
                {
                    await restClient.DeleteAsync(pcbRecord.RefURL);
                    Console.WriteLine("PersonalCallbackRecord Deleted.");
                }
            }
        }

        /// <summary>
        /// Creates a personal callback record.
        /// </summary>
        private static async Task<PersonalCallbackRecord?> CreatePersonalCallbackRecordAsync(RestClient restClient, Agent? agent)
        {
            if (agent == null)
            {
                return null;
            }

            var callbackDateTime = DateTime.UtcNow.AddYears(2);

            var pcbRecord = PopulatePersonalCallbackBean("4080000000", agent, callbackDateTime, 1);
            var refUrl = await restClient.CreateAndGetAsync(pcbRecord);
            PersonalCallbackRecord? result = null;
            if (refUrl != null)
            {
                result = await restClient.GetAsync<PersonalCallbackRecord>(refUrl);
                Console.WriteLine($"PersonalCallbackRecord created: {result?.RefURL}");
            }

            return result;
        }

        /// <summary>
        /// Create and return a PersonalCallback bean.
        /// </summary>
        /// <param name="phone">Phone number</param>
        /// <param name="agent">Agent</param>
        /// <param name="callbackDateTime">time and date for personal callback</param>
        /// <param name="maxAttempts">maximum attempts</param>
        private static PersonalCallbackRecord PopulatePersonalCallbackBean(string phone,
                                                                           Agent agent,
                                                                           DateTime callbackDateTime,
                                                                           int maxAttempts)
        {
            var pcbRecord = new PersonalCallbackRecord
            {
                AgentId = agent.AgentId,
                Agent = new ReferenceBean { RefURL = agent.RefURL },
                Phone = phone,
                CallbackDateTime = callbackDateTime,
                MaxAttempts = maxAttempts,
                Campaign = new ReferenceBean(),
                Department = new ReferenceBean()
            };

            return pcbRecord;
        }

        /// <summary>
        /// Validates the arguments based on deployment type
        /// Sets up the Agent
        /// </summary>
        private static async Task ValidateAndSetupAgentAsync(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("PersonalCallbackDemo requires 3 parameters: hostname username (with @domain) password");
                Environment.Exit(0);
            }

            // Create a new RESTClient object with the IP of you DS / AW HDS
            restClient = new RestClient(args[0], args[1], args[2]);

            var deploymentType = await restClient.GetAsync<Deployment>(RestClient.BaseUrl + "deployment");
            Console.WriteLine($"System is in Deployment Type: {deploymentType?.DeploymentType}");

            if (!DemoUtils.IsPCCEDeploymentType(deploymentType) && args.Length < 4)
            {
                Console.WriteLine("PersonalCallbackDemo requires 4 arguments in non-PCCE deployments: " +
                        "hostname username(with @domain) password agentUsername");
                Environment.Exit(0);
            }
            else if (!DemoUtils.IsPCCEDeploymentType(deploymentType))
            {
                var agentBase = await DemoUtils.LookupAgentAsync(restClient, args[3]);
                // Get the full Agent object
                if (agentBase?.RefURL != null)
                {
                    agent = await restClient.GetAsync<Agent>(agentBase.RefURL);
                }
            }

            if (DemoUtils.IsPCCEDeploymentType(deploymentType))
            {
                if (args.Length < 4)
                {
                    var agentBase = await DemoUtils.CreateAgentAsync(restClient, "Mir", "Ali", DemoUtils.GenerateUniqueString("MirAli", 1), "");
                    // Get the full Agent object
                    if (agentBase?.RefURL != null)
                    {
                        agent = await restClient.GetAsync<Agent>(agentBase.RefURL);
                        agentCreated = true;
                    }
                }
                else
                {
                    var agentBase = await DemoUtils.LookupAgentAsync(restClient, args[3]);
                    // Get the full Agent object
                    if (agentBase?.RefURL != null)
                    {
                        agent = await restClient.GetAsync<Agent>(agentBase.RefURL);
                    }
                }

                if (agent == null)
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
