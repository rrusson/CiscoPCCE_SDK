using CiscoPCCE.Toolkit.Bean;
using CiscoPCCE.Toolkit.Sdk;
using CiscoPCCE.Toolkit.Sdk.Helpers;

namespace CiscoPCCE.Toolkit.Examples
{
    /// <summary>
    /// Example code for creating agents, skill groups, and associating them.
    /// </summary>
    public class AgentSkillGroupDemo
    {
        private static readonly int UniqueBase = ((int)DateTimeOffset.UtcNow.ToUnixTimeSeconds()) % 10000;
        private static int count = 1;

        public static async Task Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("AgentSkillGroupDemo requires 3 parameters: hostname username (with @domain) password");
                Environment.Exit(0);
            }

            // Create a new RESTClient object with the IP of you DS / AW HDS
            var restClient = new CiscoRestClient(args[0], args[1], args[2]);
            await DemoUtils.CheckPCCEDeploymentTypeAsync(restClient);

            try
            {
                await AgentSkillGroupDemoAsync(restClient);
            }
            catch (ApiException e)
            {
                Console.WriteLine(e.Errors);
            }
        }

        private static async Task AgentSkillGroupDemoAsync(CiscoRestClient restClient)
        {
            // *** Agent and Skill Group Create
            // -- Make a new agent object and associate it with a new person object.
            var newAgent = PopulateAgentBean(GenerateUniqueString("firstName"), GenerateUniqueString("lastName"),
                GenerateUniqueString("userName"), "test1");

            // -- Create an agent and get an agent
            var refUrl = await restClient.CreateAndGetAsync(newAgent);
            if (refUrl != null)
            {
                newAgent = await restClient.GetAsync<Agent>(refUrl);
                Console.WriteLine($"Agent created: {newAgent?.RefURL}");
            }

            // -- Try and get an agent that doesn't exist
            try
            {
                _ = await restClient.GetAsync<Agent>(CiscoRestClient.BaseUrl + "agent/12345");
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

            // -- Create a skillgroup object.
            var skillGroup = new SkillGroup
            {
                Name = GenerateUniqueString("skill"),
                Datacenter = new ReferenceBean(),
                Department = new ReferenceBean(),
                Peripheral = new PeripheralRef(),
                PeripheralSet = new ReferenceBean(),
                BucketInterval = new ReferenceBean(),
                CampaignRef = new ReferenceBean(),
                MediaRoutingDomain = new ReferenceBean()
            };

            var skillGroupRefUrl = await restClient.CreateAndGetAsync(skillGroup);
            if (skillGroupRefUrl != null)
            {
                skillGroup = await restClient.GetAsync<SkillGroup>(skillGroupRefUrl);
                Console.WriteLine($"Skill Group created: {skillGroup?.RefURL}");
            }

            // *** Associate an Agent with a Skill Group via Update
            // -- Create a reference object with this skillgroup object so we can assign an agent to it
            var skillRef = new ReferenceBean { RefURL = skillGroup?.RefURL };

            // -- Put it in the agent object from earlier
            newAgent!.SkillGroups = new List<ReferenceBean> { skillRef };

            // -- Performing an update which will attach the skillGroup to our agent.
            _ = await restClient.UpdateAsync(newAgent);
            Console.WriteLine($"SkillGroup {skillGroup?.RefURL} assigned to agent {newAgent.RefURL}");

            // *** Show the query params (aka search) functionality
            // -- Create 2 more agents with matching descriptions
            var newAgent2RefUrl = await restClient.CreateAndGetAsync(PopulateAgentBean(GenerateUniqueString("firstName"),
                GenerateUniqueString("lastName"), GenerateUniqueString("userName"), "test2"));
            Agent? newAgent2 = null;
            if (newAgent2RefUrl != null)
            {
                newAgent2 = await restClient.GetAsync<Agent>(newAgent2RefUrl);
                Console.WriteLine($"Agent created: {newAgent2?.RefURL}");
            }

            var newAgent3RefUrl = await restClient.CreateAndGetAsync(PopulateAgentBean(GenerateUniqueString("firstName"),
                GenerateUniqueString("lastName"), GenerateUniqueString("userName"), "test2"));
            Agent? newAgent3 = null;
            if (newAgent3RefUrl != null)
            {
                newAgent3 = await restClient.GetAsync<Agent>(newAgent3RefUrl);
                Console.WriteLine($"Agent created: {newAgent3?.RefURL}");
            }

            Console.WriteLine("List all agent's with the word 'test' in the description - all 3");
            var itemList = await restClient.GetListAsync<AgentList>("test");
            if (itemList?.Items != null)
            {
                foreach (var i in itemList.Items)
                {
                    Console.WriteLine($"{i.Person?.UserName} description {i.Description}");
                }
            }

            Console.WriteLine("List all agent's with the word 'test2' in the description - the 2 newly created ones");
            itemList = await restClient.GetListAsync<AgentList>("test2");
            if (itemList?.Items != null)
            {
                foreach (var i in itemList.Items)
                {
                    Console.WriteLine($"{i.Person?.UserName} description {i.Description}");
                }
            }

            // *** Finally Delete everything
            var beansToDelete = new List<BaseApiBean>();
            if (newAgent != null)
            {
                beansToDelete.Add(newAgent);
            }

            if (newAgent2 != null)
            {
                beansToDelete.Add(newAgent2);
            }

            if (newAgent3 != null)
            {
                beansToDelete.Add(newAgent3);
            }

            if (skillGroup != null)
            {
                beansToDelete.Add(skillGroup);
            }

            foreach (var bean in beansToDelete)
            {
                await restClient.DeleteAsync(bean.RefURL!);
                Console.WriteLine($"Deleted {bean.GetType().Name}: {bean.RefURL}");
            }
        }

        private static Agent PopulateAgentBean(string firstName, string lastName, string userName, string description)
        {
            var newAgent = new Agent
            {
                Person = new Person
                {
                    FirstName = firstName,
                    LastName = lastName,
                    UserName = userName,
                    Department = new ReferenceBean()
                },
                Description = description,
                AgentDeskSettings = new ReferenceBean(),
                AgentTeam = new ReferenceBean(),
                Datacenter = new ReferenceBean(),
                DefaultSkillGroup = new ReferenceBean(),
                Department = new ReferenceBean(),
                Peripheral = new PeripheralRef(),
                PeripheralSet = new ReferenceBean()
            };

            return newAgent;
        }

        private static string GenerateUniqueString(string baseStr)
        {
            return string.Format("{0}_{1:D3}_{2:D5}", baseStr, UniqueBase, count++);
        }
    }
}
