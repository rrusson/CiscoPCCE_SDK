using CiscoPCCE.Toolkit.Bean;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Examples
{
    /// <summary>
    /// Example code for creating agent with agent service enabled.
    /// </summary>
    public class EnableAgentServiceDemo
    {
        public static async Task Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("EnableAgentServiceDemo requires 3 parameters: hostname username (with @domain) password");
                Environment.Exit(0);
            }

            // Create a new RESTClient object with the IP of AW HDS
            var restClient = new CiscoRestClient(args[0], args[1], args[2]);
            await DemoUtils.CheckPCCEDeploymentTypeAsync(restClient);

            try
            {
                await EnableAgentServiceDemoAsync(restClient);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception occurred: {e.Message}");
            }
        }

        private static async Task EnableAgentServiceDemoAsync(CiscoRestClient restClient)
        {
            // Create a new agent with 3 agent services enabled
            // Note: Based on the C# Bean structure, we use MappedServiceType
            var newAgent = new Agent
            {
                AgentServicesEnabled = new List<AgentServiceEnabled>
                {
                    new AgentServiceEnabled { MappedServiceType = "AgentAnswers" },
                    new AgentServiceEnabled { MappedServiceType = "Transcript" },
                    new AgentServiceEnabled { MappedServiceType = "VAVTranscript" }
                },
                Person = new Person
                {
                    EcePerson = false,
                    FirstName = DemoUtils.GenerateUniqueString("firstName", 1),
                    LastName = DemoUtils.GenerateUniqueString("lastName", 1),
                    LoginEnabled = true,
                    SsoEnabled = false,
                    UserName = DemoUtils.GenerateUniqueString("userName", 1),
                    Department = new ReferenceBean()
                },
                AgentDeskSettings = new ReferenceBean(),
                AgentTeam = new ReferenceBean(),
                Datacenter = new ReferenceBean(),
                DefaultSkillGroup = new ReferenceBean(),
                Department = new ReferenceBean(),
                Peripheral = new PeripheralRef(),
                PeripheralSet = new ReferenceBean()
            };

            // -- Create and get the agent
            var refUrl = await restClient.CreateAndGetAsync(newAgent);
            Agent? createdAgent = null;
            if (refUrl != null)
            {
                createdAgent = await restClient.GetAsync<Agent>(refUrl);
                Console.WriteLine($"Agent created: {createdAgent?.RefURL}");
                var services = createdAgent?.AgentServicesEnabled?.Select(s => s.MappedServiceType ?? "").ToList() ?? new List<string>();
                Console.WriteLine($"Agent Services enabled for the agent: {string.Join(", ", services)}");
            }

            // delete the agent
            if (createdAgent?.RefURL != null)
            {
                await restClient.DeleteAsync(createdAgent.RefURL);
                Console.WriteLine($"Deleted Agent: {createdAgent.RefURL}");
            }
        }
    }
}
