using CiscoPCCE.Toolkit.Bean;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Examples
{
    /// <summary>
    /// Example code for creating a digital agent.
    /// </summary>
    public class EnableDigitalAgentsDemo
    {
        private static CiscoRestClient? restClient = null;

        public static async Task Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("EnableDigitalAgentsDemo requires 3 parameters: hostname username (with @domain) password");
                Environment.Exit(0);
            }

            // Create a new RESTClient object with the IP of AW HDS
            restClient = new CiscoRestClient(args[0], args[1], args[2]);

            try
            {
                await EnableDigitalAgentsDemoAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception occurred: {e.Message}");
            }
        }

        private static async Task EnableDigitalAgentsDemoAsync()
        {
            // Create a digital agent using the Agent class
            var newAgent = new Agent
            {
                Person = new Person
                {
                    DigitalChannel = true,
                    EmailAddress = "xyz@cisco.com",
                    EcePerson = false,
                    FirstName = DemoUtils.GenerateUniqueString("firstName", 1),
                    LastName = DemoUtils.GenerateUniqueString("lastName", 1),
                    LoginEnabled = true,
                    SsoEnabled = true,
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
            var refUrl = await restClient!.CreateAndGetAsync(newAgent);
            Agent? createdAgent = null;
            if (refUrl != null)
            {
                createdAgent = await restClient.GetAsync<Agent>(refUrl);
                Console.WriteLine($"Digital Agent created: {createdAgent?.RefURL}");
                Console.WriteLine($"Digital Agent Email ID: {createdAgent?.Person?.EmailAddress}");
            }

            // delete the digital agent
            if (createdAgent?.RefURL != null)
            {
                await restClient.DeleteAsync(createdAgent.RefURL);
                Console.WriteLine($"Deleted Digital Agent: {createdAgent.RefURL}");
            }
        }
    }
}
