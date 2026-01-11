namespace CiscoPCCE.Toolkit.Sdk.AgentApi
{
	public class AgentSearchCriteria
    {
        public string? AgentId { get; set; }
        public string? Description { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? UserName { get; set; }

        public bool? Supervisor { get; set; }
        public bool? EceAgent { get; set; }

        public List<string>? Attributes { get; set; }
        public List<string>? SkillGroups { get; set; }
        public List<string>? Teams { get; set; }
        public List<string>? DataCenters { get; set; }
        public List<string>? PeripheralSets { get; set; }
    }
}
