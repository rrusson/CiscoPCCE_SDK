namespace CiscoPCCE.Toolkit.Sdk.AgentApi
{
    internal static class AgentRequestBuilder
    {
        /// <summary>
        /// Builds a special query string representation from the specified agent search criteria (not a standard URL query string).
        /// </summary>
        /// <param name="criteria">The search criteria used to construct the query string</param>
        /// <returns>A string containing the query parameters based on the provided criteria. Returns an empty string if no criteria are specified.</returns>
        /// <remarks>The resulting query string includes only the fields from the criteria that are set. Advanced parameters may also be included if specified in the criteria.</remarks>
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

            AddAdvancedParameters(criteria, parts);

            return string.Join(" ", parts);
        }

        private static void AddAdvancedParameters(AgentSearchCriteria criteria, List<string> parts)
        {
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
        }
    }
}
