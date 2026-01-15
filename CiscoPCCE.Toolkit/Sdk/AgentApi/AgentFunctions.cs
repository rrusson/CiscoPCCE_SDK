using CiscoPCCE.Toolkit.Bean;
using CiscoPCCE.Toolkit.Sdk.Interfaces;

namespace CiscoPCCE.Toolkit.Sdk.AgentApi
{
    /// <summary>
    /// API wrapper for Cisco PCCE Agent operations
    /// </summary>
    public class AgentFunctions : IAgentFunctions
    {
        private readonly ICiscoRestClient _restClient;
        private const string BasePath = "agent";

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentFunctions"/> class.
        /// </summary>
        /// <param name="restClient">The REST client used to communicate with the Cisco PCCE Agent API.</param>
        /// <param name="maxResults">
        /// The maximum number of results to request from the API for list and search operations.
        /// Defaults to <c>100</c> when no value is specified.
        /// </param>
        public AgentFunctions(ICiscoRestClient restClient, int maxResults = 100)
        {
            _restClient = restClient;
            restClient.MaxResults = maxResults;
        }

        /// <inheritdoc/>
        public async Task<string?> CreateAgentAsync(Agent agent)
        {
            // Return reference URL
            return await _restClient.CreateAndGetAsync(agent).ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public async Task DeleteAgentAsync(string agentId)
        {
            await _restClient.DeleteAsync($"{CiscoRestClient.BaseUrl}{BasePath}/{agentId}").ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public async Task DeleteAgentAsync(Agent agent)
        {
            if (agent.RefURL != null)
            {
                await _restClient.DeleteAsync(agent.RefURL).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        public async Task<Agent?> GetAgentAsync(string agentId)
        {
            return await _restClient.GetAsync<Agent>($"{CiscoRestClient.BaseUrl}{BasePath}/{agentId}").ConfigureAwait(false);
        }

        /// <inheritdoc/>
        public async Task<Agent?> GetAgentByOtherIdAsync(int otherId)
        {
            // Special, undocumented case of search (without normal criteria querystring) to find an Agent based on alternate AgentId (e.g. employeeId)
            var agentList = await _restClient.GetListAsync<AgentList>($"{otherId}", BasePath).ConfigureAwait(false);

            // Return first matching agent found (Note: typically marked as AgentId in payload, although different from Cisco's internal PK for AgentId)
            return agentList?.Items?.FirstOrDefault();
        }

        /// <inheritdoc/>
        public async Task<List<Agent>?> GetAgentsAsync()
        {
            var result = await _restClient.GetListAsync<AgentList>(null, BasePath);
            return result?.Items;
        }

        /// <inheritdoc/>
        public async Task<List<Agent>?> GetAgentsAsync(AgentSearchCriteria criteria)
        {
            var queryString = AgentRequestBuilder.BuildQueryString(criteria);
            var result = await _restClient.GetListAsync<AgentList>(queryString, BasePath).ConfigureAwait(false);

            return result?.Items;
        }

        /// <inheritdoc/>
        public async Task<bool> UpdateAgentAsync(Agent agent)
        {
            if (agent.ChangeStamp is null or < 1)
            {
                throw new ArgumentException("Agent ChangeStamp must have a valid value for update operations.", nameof(agent));
            }

            var response = await _restClient.UpdateAsync(agent).ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        /// <inheritdoc/>
        public async Task<Agent?> UpdateAndGetAgentAsync(Agent agent)
        {
            if (agent.ChangeStamp is null or < 1)
            {
                throw new ArgumentException("Agent ChangeStamp must have a valid value for update operations.", nameof(agent));
            }

            return await _restClient.UpdateAndGetBeanAsync(agent).ConfigureAwait(false);
        }
    }
}
