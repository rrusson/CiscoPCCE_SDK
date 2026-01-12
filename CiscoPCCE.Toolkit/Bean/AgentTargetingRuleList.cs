using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("agenttargetingrule")
    [XmlRoot("results")]
    public class AgentTargetingRuleList : BaseApiList<AgentTargetingRule>
    {
        [XmlArray("agentTargetingRules")]
        [XmlArrayItem("agentTargetingRule")]
        public new List<AgentTargetingRule>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }
    }
}