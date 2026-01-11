using CiscoPCCE.Toolkit.Bean;

namespace CiscoPCCE.Toolkit.Sdk.AgentApi
{
	/// <summary>
	/// API wrapper for Agent operations.
	/// </summary>
	public class AgentFunctions
	{
		private readonly RestClient _restClient;
		private const string BasePath = "agent";

		public AgentFunctions(RestClient restClient)
		{
			_restClient = restClient;
		}

		/// <summary>
		/// Retrieves a list of agents.
		/// </summary>
		public async Task<List<AgentBase>?> GetAgentsAsync()
		{
			var result = await _restClient.GetListAsync<AgentList>(null, BasePath);
			return result?.Items;
		}

		/// <summary>
		/// Retrieves a list of agents matching the search criteria.
		/// </summary>
		public async Task<List<AgentBase>?> GetAgentsAsync(AgentSearchCriteria criteria)
		{
			var queryString = BuildQueryString(criteria);
			var result = await _restClient.GetListAsync<AgentList>(queryString, BasePath);
			return result?.Items;
		}

		/// <summary>
		/// Returns one agent by ID.
		/// </summary>
		public async Task<Agent?> GetAgentAsync(string id)
		{
			return await _restClient.GetAsync<Agent>($"{RestClient.BaseUrl}{BasePath}/{id}");
		}

		/// <summary>
		/// Creates an agent.
		/// </summary>
		/// <returns>The RefURL of the created agent.</returns>
		public async Task<string?> CreateAgentAsync(Agent agent)
		{
			return await _restClient.CreateAndGetAsync(agent);
		}

		/// <summary>
		/// Updates one agent.
		/// </summary>
		public async Task UpdateAgentAsync(Agent agent)
		{
			await _restClient.UpdateAsync(agent);
		}

		/// <summary>
		/// Updates one agent and returns the updated object.
		/// </summary>
		public async Task<Agent?> UpdateAndGetAgentAsync(Agent agent)
		{
			return await _restClient.UpdateAndGetBeanAsync(agent);
		}

		/// <summary>
		/// Marks one agent for deletion.
		/// </summary>
		public async Task DeleteAgentAsync(string id)
		{
			await _restClient.DeleteAsync($"{RestClient.BaseUrl}{BasePath}/{id}");
		}

		/// <summary>
		/// Helper to delete by Agent object refURL
		/// </summary>
		public async Task DeleteAgentAsync(Agent agent)
		{
			if (agent.RefURL != null)
			{
				await _restClient.DeleteAsync(agent.RefURL);
			}
		}

		private string BuildQueryString(AgentSearchCriteria criteria)
		{
			var parts = new List<string>();

			// Standard search parameters
			if (!string.IsNullOrWhiteSpace(criteria.AgentId))
			{
				parts.Add($"agentId:{criteria.AgentId}");
			}

			if (!string.IsNullOrWhiteSpace(criteria.Description))
			{
				parts.Add($"description:{criteria.Description}");
			}

			if (!string.IsNullOrWhiteSpace(criteria.FirstName))
			{
				parts.Add($"person.firstName:{criteria.FirstName}");
			}

			if (!string.IsNullOrWhiteSpace(criteria.LastName))
			{
				parts.Add($"person.lastName:{criteria.LastName}");
			}

			if (!string.IsNullOrWhiteSpace(criteria.UserName))
			{
				parts.Add($"person.userName:{criteria.UserName}");
			}

			// Advanced parameters
			// supervisor: (true/false)
			if (criteria.Supervisor.HasValue)
			{
				parts.Add($"supervisor:{criteria.Supervisor.Value.ToString().ToLower()}");
			}

			// eceagent: (true/false)
			if (criteria.EceAgent.HasValue)
			{
				parts.Add($"eceagent:{criteria.EceAgent.Value.ToString().ToLower()}");
			}

			// attributes: (attr1 & attr2...)
			if (criteria.Attributes != null && criteria.Attributes.Count > 0)
			{
				var attrs = string.Join(" & ", criteria.Attributes);
				parts.Add($"attributes:({attrs})");
			}

			// skillgroups: (skill1 & skill2 ...)
			if (criteria.SkillGroups != null && criteria.SkillGroups.Count > 0)
			{
				var skills = string.Join(" & ", criteria.SkillGroups);
				parts.Add($"skillgroups:({skills})");
			}

			// team: (team1|team2...)
			if (criteria.Teams != null && criteria.Teams.Count > 0)
			{
				var teams = string.Join("|", criteria.Teams);
				parts.Add($"team:({teams})");
			}

			// datacenters: (dc1|dc2...)
			if (criteria.DataCenters != null && criteria.DataCenters.Count > 0)
			{
				var dcs = string.Join("|", criteria.DataCenters);
				parts.Add($"datacenters:({dcs})");
			}

			// peripheralsets: (ps1|ps2...)
			if (criteria.PeripheralSets != null && criteria.PeripheralSets.Count > 0)
			{
				var psets = string.Join("|", criteria.PeripheralSets);
				parts.Add($"peripheralsets:({psets})");
			}

			return string.Join(" ", parts);
		}
	}
}
