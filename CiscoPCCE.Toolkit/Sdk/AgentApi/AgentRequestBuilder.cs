using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiscoPCCE.Toolkit.Sdk.AgentApi
{
	internal class AgentRequestBuilder
	{
		internal static string BuildQueryString(AgentSearchCriteria criteria)
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
