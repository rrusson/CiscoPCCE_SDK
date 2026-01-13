namespace CiscoPCCE.Toolkit.Sdk.AgentApi
{
    public class AgentSearchCriteria
    {
        /// <summary>
        /// The unique identifier of the agent
        /// </summary>
        public string? AgentId { get; set; }

        /// <summary>
        /// The description associated with the agent
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// The first name of the agent
        /// </summary>
        public string? FirstName { get; set; }

        /// <summary>
        /// The last name of the agent
        /// </summary>
        public string? LastName { get; set; }

        /// <summary>
        /// The user name of the agent
        /// </summary>
        public string? UserName { get; set; }


        #region Advanced search parameters
        /// <summary>
        /// Indicates whether to filter to agents with supervisor status
        /// </summary>
        public bool? Supervisor { get; set; }

        /// <summary>
        /// Indicates whether to filter to Enterprise Chat and Email (ECE) agents
        /// </summary>
        public bool? EceAgent { get; set; }

        /// <summary>
        /// A collection of attribute names used to filter agents by their assigned attributes
        /// </summary>
        /// <remarks>Specify up to 10 attribute names to find agents that possess all listed attributes.
        /// Attribute names are fully matched; partial matches are not supported. This property is typically used in
        /// conjunction with other filtering criteria such as skill groups, teams, data centers, or peripheral sets to
        /// refine agent selection.</remarks>
        public List<string>? Attributes { get; set; }

        /// <summary>
        /// A collection of skill group names associated with the agent
        /// </summary>
        /// <remarks>Specify up to 10 skill groups. The skill group names are fully matched.</remarks>
        public List<string>? SkillGroups { get; set; }

        /// <summary>
        /// A collection of team names associated with the agent
        /// </summary>
        /// <remarks>Specify up to 10 team names. The team names are fully matched.</remarks>
        public List<string>? Teams { get; set; }

        /// <summary>
        /// A collection of data center names associated with the agent
        /// </summary>
        /// <remarks>Specify up to 3 data center names. The data center names are fully matched (case-insensitive, no partial matches).</remarks>
        public List<string>? DataCenters { get; set; }

        /// <summary>
        /// A collection of peripheral set names associated with the agent
        /// </summary>
        /// <remarks>The peripheral set names are fully matched (case-insensitive, no partial matches).</remarks>
        public List<string>? PeripheralSets { get; set; }
        #endregion
    }
}
