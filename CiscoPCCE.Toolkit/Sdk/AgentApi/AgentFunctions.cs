using CiscoPCCE.Toolkit.Bean;
using CiscoPCCE.Toolkit.Sdk.Interfaces;

namespace CiscoPCCE.Toolkit.Sdk.AgentApi
{
    /// <summary>
    /// API wrapper for Agent operations
    /// </summary>
    public class AgentFunctions
    {
        private readonly ICiscoRestClient _restClient;
        private const string BasePath = "agent";

        /// <summary>
        /// Initializes a new instance of the AgentFunctions class using the specified REST client
        /// </summary>
        /// <param name="restClient">The RestClient instance used to perform HTTP operations for agent-related functionality</param>
        public AgentFunctions(ICiscoRestClient restClient)
        {
            _restClient = restClient;
        }

        /// <summary>
        /// Returns one Agent matching the <paramref name="agentId"/>
        /// </summary>
        /// <returns>The agent with the specified ID</returns>
        public async Task<Agent?> GetAgentAsync(string agentId)
        {
            return await _restClient.GetAsync<Agent>($"{CiscoRestClient.BaseUrl}{BasePath}/{agentId}");
        }

        /// <summary>
        /// Searchs for and returns first Agent matching on <paramref name="otherId"/> (e.g. employeeId)
        /// </summary>
        /// <returns>The agent with specified <paramref name="otherId"/> (but different from Cisco internal AgentId)</returns>
        public async Task<Agent?> GetAgentByOtherIdAsync(int otherId)
        {
            // Special, undocumented case of search (without normal criteria querystring) to find an Agent based on alternate AgentId (e.g. employeeId)
            var agentList = await _restClient.GetListAsync<AgentList>($"{otherId}", BasePath);

            // Return first matching agent found (Note: typically marked as AgentId in payload, although different from Cisco's internal PK for AgentId)
            return agentList?.Items?.FirstOrDefault();
        }

        /// <summary>
        /// Retrieves a list of agents
        /// </summary>
        /// <returns>A list of agents</returns>
        public async Task<List<Agent>?> GetAgentsAsync()
        {
            var result = await _restClient.GetListAsync<AgentList>(null, BasePath);
            return result?.Items;
        }

        /// <summary>
        /// Retrieves a list of agents matching the search criteria
        /// </summary>
        /// <param name="criteria">The search criteria</param>
        /// <returns>A list of agents matching the criteria</returns>
        public async Task<List<Agent>?> GetAgentsAsync(AgentSearchCriteria criteria)
        {
            var queryString = AgentRequestBuilder.BuildQueryString(criteria);
            var result = await _restClient.GetListAsync<AgentList>(queryString, BasePath);
            return result?.Items;
        }

        /// <summary>
        /// Creates an agent
        /// </summary>
        /// <returns>The RefURL of the created agent</returns>
        public async Task<string?> CreateAgentAsync(Agent agent)
        {
            return await _restClient.CreateAndGetAsync(agent);
        }

        /// <summary>
        /// Updates one agent
        /// </summary>
        /// <param name="agent">The agent to update</param>
        /// <remarks>
        /// - When you change the team association for an agent or supervisor in Packaged CCE, the same change is updated in the corresponding collection in Unified Intelligence Center.
        /// - When you change the username and team association for a supervisor's record, the same changes are also updated in the corresponding user account in Unified Intelligence Center.
        /// - For an existing supervisor's record in Packaged CCE, if the value for the Supervisor parameter is set to false, the corresponding user account is deleted from Unified Intelligence Center.
        /// </remarks>
        public async Task UpdateAgentAsync(Agent agent)
        {
            if (agent.ChangeStamp is null or < 1)
            {
                throw new ArgumentException("Agent ChangeStamp must have a valid value for update operations.", nameof(agent));
            }

            _ = await _restClient.UpdateAsync(agent);
        }

        /// <summary>
        /// Updates one agent and returns the updated object.
        /// </summary>
        public async Task<Agent?> UpdateAndGetAgentAsync(Agent agent)
        {
            if (agent.ChangeStamp is null or < 1)
            {
                throw new ArgumentException("Agent ChangeStamp must have a valid value for update operations.", nameof(agent));
            }

            return await _restClient.UpdateAndGetBeanAsync(agent);
        }

        /// <summary>
        /// Marks one agent for deletion
        /// </summary>
        /// <param name="id">The ID of the agent to delete</param>
        public async Task DeleteAgentAsync(string id)
        {
            await _restClient.DeleteAsync($"{CiscoRestClient.BaseUrl}{BasePath}/{id}");
        }

        /// <summary>
        /// Helper to delete by Agent object refURL
        /// </summary>
        /// <param name="agent">The agent to delete</param>
        public async Task DeleteAgentAsync(Agent agent)
        {
            if (agent.RefURL != null)
            {
                await _restClient.DeleteAsync(agent.RefURL);
            }
        }
    }
}
