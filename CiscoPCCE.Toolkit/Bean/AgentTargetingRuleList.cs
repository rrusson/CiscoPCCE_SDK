using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("agenttargetingrule")
    [XmlRoot("results")]
    public class AgentTargetingRuleList : BaseApiBean
    {
        [XmlElement("agentTargetingRules")]
        [XmlElement("agentTargetingRule")]
        public List<AgentTargetingRule>? Items { get; set; }

        public required PageInfo PageInfo { get; set; }

        public required PermissionInfo PermissionInfo { get; set; }

        // Path("agenttargetingrule")
        [XmlRoot("results")]
        public class AgentTargetingRuleListList : BaseApiListBean<AgentTargetingRuleList>
        {
            public override List<AgentTargetingRuleList>? GetItems() => Items;

            public override void SetItems(List<AgentTargetingRuleList>? value) => Items = value;
        }
    }
}