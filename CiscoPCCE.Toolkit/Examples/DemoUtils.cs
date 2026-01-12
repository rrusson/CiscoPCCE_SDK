using CiscoPCCE.Toolkit.Bean;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Examples
{
    /// <summary>
    /// Utility methods for Demo classes
    /// </summary>
    public static class DemoUtils
    {
        public const string CommaDelimiter = ",";
        public const string PipeDelimiter = "|";

        public static readonly int UniqueBase = ((int)DateTimeOffset.UtcNow.ToUnixTimeSeconds()) % 10000;
        public const int PCCE_2K = 7;
        public const int PCCE_LAB = 10;
        public const int PCCE_4K = 17;
        public const int PCCE_12K = 18;

        /// <summary>
        /// Generates a unique string to be used while creating new objects
        /// </summary>
        /// <param name="baseStr">base name for the object</param>
        /// <param name="count">count</param>
        /// <returns>unique string</returns>
        public static string GenerateUniqueString(string baseStr, int count)
        {
            return string.Format("{0}_{1:D3}_{2:D5}", baseStr, UniqueBase, count);
        }

        /// <summary>
        /// Deletes a list of beans
        /// </summary>
        /// <param name="restClient">Rest Client</param>
        /// <param name="beans">beans to be deleted</param>
        public static async Task DeleteAsync(RestClient restClient, List<BaseApiBean> beans)
        {
            foreach (var bean in beans)
            {
                await restClient.DeleteAsync(bean.RefURL!);
                Console.WriteLine($"Deleted {bean.GetType().Name}: {bean.RefURL}");
            }
        }

        /// <summary>
        /// Creates an Agent
        /// </summary>
        /// <param name="restClient">Rest Client</param>
        /// <param name="firstName">agent's first name</param>
        /// <param name="lastName">agent's last name</param>
        /// <param name="userName">agent's username</param>
        /// <param name="description">agent's description</param>
        /// <returns>Created Agent</returns>
        public static async Task<Agent?> CreateAgentAsync(RestClient restClient, string firstName, string lastName, string userName, string description)
        {
            var agent = PopulateAgentBean(firstName, lastName, userName, description);
            var refUrl = await restClient.CreateAndGetAsync(agent);
            if (refUrl != null)
            {
                agent = await restClient.GetAsync<Agent>(refUrl);
                Console.WriteLine($"Agent created: {agent?.RefURL}");
            }
            return agent;
        }

        /// <summary>
        /// Set up the Agent bean
        /// </summary>
        /// <param name="firstName">agent's first name</param>
        /// <param name="lastName">agent's last name</param>
        /// <param name="userName">agent's username</param>
        /// <param name="description">agent's description</param>
        /// <returns>Agent</returns>
        public static Agent PopulateAgentBean(string firstName, string lastName, string userName, string description)
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

        /// <summary>
        /// Searches for a SkillGroup by skillGroupName
        /// If not found, returns null
        /// If more than one found, returns exact matching name
        /// If exact match not found, returns the first match found
        /// </summary>
        /// <param name="restClient">RestClient</param>
        /// <param name="skillGroupName">Name of the SkillGroup</param>
        /// <returns>SkillGroup or null</returns>
        public static async Task<SkillGroupBase?> LookupSkillGroupAsync(RestClient restClient, string skillGroupName)
        {
            var skillGroups = await restClient.GetListAsync<SkillGroupList>(skillGroupName);

            // If no Skill Group is found with the search term, return null.
            if (skillGroups?.Items == null || skillGroups.Items.Count == 0)
            {
                Console.WriteLine($"No SkillGroup was found with Skill Group name: {skillGroupName}");
                return null;
            }

            // Look for exact matching name and return that Skill Group
            foreach (var skillGroup in skillGroups.Items)
            {
                if (skillGroup.Name == skillGroupName)
                {
                    return skillGroup;
                }
            }

            // If no Skill Group name matches the exact search term, then select the first skill group in the list
            var selectedSkillGroup = skillGroups.Items[0];
            Console.WriteLine($"No SkillGroup matched the name: '{skillGroupName}'. Selecting Skill Group with name: {selectedSkillGroup.Name}");
            return selectedSkillGroup;
        }

        /// <summary>
        /// Searches for an Agent by Agent username
        /// If not found, returns null
        /// If more than one found, returns exact matching agent username
        /// If exact match not found, returns the first match found
        /// </summary>
        /// <param name="restClient">RestClient</param>
        /// <param name="agentUsername">username of the Agent</param>
        /// <returns>Agent or null</returns>
        public static async Task<Agent?> LookupAgentAsync(RestClient restClient, string agentUsername)
        {
            var agents = await restClient.GetListAsync<AgentList>(agentUsername);

            // If no agent username is found with the search term, return null.
            if (agents?.Items == null || agents.Items.Count == 0)
            {
                Console.WriteLine($"No Agent was found with username: {agentUsername}");
                return null;
            }

            // Look for exact matching agent username and return that Agent
            foreach (var agent in agents.Items)
            {
                if (agent.Person?.UserName == agentUsername)
                {
                    return agent;
                }
            }

            // If no Agent username matches the exact search term, then select the first AgentId in the list
            var selectedAgent = agents.Items[0];
            Console.WriteLine($"No Agent username matched: '{agentUsername}'. Selecting Agent with username: {selectedAgent.Person?.UserName}");
            return selectedAgent;
        }

        /// <summary>
        /// Check and exit if deployment type is not PCCE
        /// </summary>
        /// <param name="restClient">RestClient</param>
        public static async Task CheckPCCEDeploymentTypeAsync(RestClient restClient)
        {
            var deploymentType = await restClient.GetAsync<Deployment>(RestClient.BaseUrl + "deployment");

            Console.WriteLine($"System is in Deployment Type: {deploymentType?.DeploymentType}");

            bool isPCCE = IsPCCEDeploymentType(deploymentType);

            if (!isPCCE)
            {
                Console.WriteLine("This demo can only be run in PCCE deployments.");
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// Checks if deployment type is PCCE
        /// </summary>
        /// <param name="deploymentType">Deployment Type</param>
        /// <returns>true if deployment type is PCCE</returns>
        public static bool IsPCCEDeploymentType(Deployment? deploymentType)
        {
            if (deploymentType == null)
            {
                return false;
            }

            return deploymentType.DeploymentType is PCCE_2K or
                   PCCE_LAB or
                   PCCE_4K or
                   PCCE_12K;
        }
    }
}
