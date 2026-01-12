using System.ComponentModel.DataAnnotations;

using CiscoPCCE.Toolkit.Bean;
using CiscoPCCE.Toolkit.Sdk.Interfaces;

namespace CiscoPCCE.Toolkit.Sdk.AgentApi
{
	/// <summary>
	/// API wrapper for Agent operations
	/// </summary>
	public class AgentFunctions
	{
		private readonly IRestClient _restClient;
		private const string BasePath = "agent";

		/// <summary>
		/// Initializes a new instance of the AgentFunctions class using the specified REST client
		/// </summary>
		/// <param name="restClient">The RestClient instance used to perform HTTP operations for agent-related functionality</param>
		public AgentFunctions([Required] IRestClient restClient)
		{
			_restClient = restClient;
		}

		/// <summary>
		/// Retrieves a list of agents
		/// </summary>
		/// <returns>A list of agents</returns>
		public async Task<List<AgentBase>?> GetAgentsAsync()
		{
			var result = await _restClient.GetListAsync<AgentList>(null, BasePath);
			return result?.Items;
		}

		/// <summary>
		/// Retrieves a list of agents matching the search criteria
		/// </summary>
		/// <param name="criteria">The search criteria</param>
		/// <returns>A list of agents matching the criteria</returns>
		public async Task<List<AgentBase>?> GetAgentsAsync(AgentSearchCriteria criteria)
		{
			var queryString = AgentRequestBuilder.BuildQueryString(criteria);
			var result = await _restClient.GetListAsync<AgentList>(queryString, BasePath);
			return result?.Items;
		}

		/// <summary>
		/// Returns one agent matching the <paramref name="id"/>
		/// </summary>
		/// <returns>The agent with the specified ID</returns>
		public async Task<Agent?> GetAgentAsync(string id)
		{
			return await _restClient.GetAsync<Agent>($"{RestClient.BaseUrl}{BasePath}/{id}");
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

			await _restClient.UpdateAsync(agent);
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
			await _restClient.DeleteAsync($"{RestClient.BaseUrl}{BasePath}/{id}");
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
