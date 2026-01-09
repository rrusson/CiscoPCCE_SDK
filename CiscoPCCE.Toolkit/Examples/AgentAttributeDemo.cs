using CiscoPCCE.Toolkit.Bean;

namespace CiscoPCCE.Toolkit.Examples
{
    /// <summary>
    /// Example code for creating agents, Attributes, and associating them.
    /// </summary>
    public class AgentAttributeDemo
    {
        private static readonly int UniqueBase = ((int)(DateTimeOffset.UtcNow.ToUnixTimeSeconds())) % 10000;
        private static int count = 1;

        public static async Task Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("AgentAttributeDemo requires 3 parameters: hostname username (with @domain) password");
                Environment.Exit(0);
            }

            // Create a new RESTClient object with the IP of you DS / AW HDS
            var restClient = new RESTClient(args[0], args[1], args[2]);

            var deploymentType = await restClient.GetAsync<Deployment>(RESTClient.BaseUrl + "deployment");

            Console.WriteLine($"System is in Deployment Type: {deploymentType?.DeploymentType}");

            try
            {
                await AgentAttributeDemoAsync(restClient, deploymentType);
            }
            catch (ApiException e)
            {
                Console.WriteLine(e.Errors);
            }
        }

        private static async Task AgentAttributeDemoAsync(RESTClient restClient, Deployment? deploymentType)
        {
            // *** Agent Find (UCCE) or Create (PCCE)
            Agent? agent = null;
            if (deploymentType?.DeploymentType != 7 && deploymentType?.DeploymentType != 10)
            {
                var agents = await restClient.GetListAsync<AgentList>();

                if (agents?.Items == null || agents.Items.Count == 0)
                {
                    Console.WriteLine("No Agents were found. At least one agent must exist for a UCCE demo");
                    Environment.Exit(0);
                }
                else
                {
                    // Get the first agent and retrieve full details
                    var firstAgentBase = agents.Items[0];
                    if (firstAgentBase.RefURL != null)
                    {
                        agent = await restClient.GetAsync<Agent>(firstAgentBase.RefURL);
                        Console.WriteLine($"Agent Selected for Test: {agent?.RefURL}");
                    }
                }
            }
            else
            {
                var agentBean = PopulateAgentBean(GenerateUniqueString("firstName"), GenerateUniqueString("lastName"),
                    GenerateUniqueString("userName"), "test1");
                var agentRefUrl = await restClient.CreateAndGetAsync(agentBean);
                if (agentRefUrl != null)
                {
                    agent = await restClient.GetAsync<Agent>(agentRefUrl);
                    Console.WriteLine($"Agent created: {agent?.RefURL}");
                }
            }

            if (agent == null)
            {
                Console.WriteLine("Failed to obtain an agent for the demo");
                return;
            }

            // Save off any attributes on the current agent
            var existingAttributes = agent.Attributes ?? new List<AttributeValueWithAttribute>();

            // -- Create an attribute object.
            var attribute = new Bean.Attribute
            {
                DataType = 3,
                DefaultValue = "true",
                Name = GenerateUniqueString("attribute"),
                Department = new ReferenceBean()
            };
            var attributeRefUrl = await restClient.CreateAndGetAsync(attribute);
            if (attributeRefUrl != null)
            {
                attribute = await restClient.GetAsync<Bean.Attribute>(attributeRefUrl);
            }

            // *** Associate an Agent with an Attribute via Update
            var agentAttribute = new AttributeValueWithAttribute
            {
                AttributeValue = "true",
                Attribute = new ReferenceBean { RefURL = attribute?.RefURL }
            };

            // -- Put it in the agent object from earlier
            agent.Attributes = new List<AttributeValueWithAttribute> { agentAttribute };

            // -- Performing an update which will attach the attribute to our agent.
            agent = await restClient.UpdateAndGetBeanAsync(agent);
            Console.WriteLine($"Attribute {agentAttribute.Attribute.RefURL} assigned to agent {agent?.RefURL}");

            // *** Remove the association
            agent!.Attributes = existingAttributes;
            agent = await restClient.UpdateAndGetBeanAsync(agent);
            Console.WriteLine("Agent restored to existing attribute set");

            // ** Delete the attribute (and Agent if PCCE)
            if (attribute?.RefURL != null)
            {
                await restClient.DeleteAsync(attribute.RefURL);
                Console.WriteLine($"Deleted Attribute: {attribute.RefURL}");
            }

            if ((deploymentType?.DeploymentType == 7 || deploymentType?.DeploymentType == 10) && agent.RefURL != null)
            {
                await restClient.DeleteAsync(agent.RefURL);
                Console.WriteLine($"Deleted Agent: {agent.RefURL}");
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
