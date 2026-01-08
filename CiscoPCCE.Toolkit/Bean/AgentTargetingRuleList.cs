using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("agenttargetingrule")
    [XmlRoot("results")]
    public class AgentTargetingRuleList : BaseApiBean
    {
        [XmlArray("agentTargetingRules")]
        [XmlArrayItem("agentTargetingRule")]
        public List<AgentTargetingRule>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("agenttargetingrule")
        [XmlRoot("results")]
        public class AgentTargetingRuleListList : BaseApiListBean<AgentTargetingRuleList>
        {
            [XmlArray("resultss")]
            [XmlArrayItem("results")]
            public new List<AgentTargetingRuleList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<AgentTargetingRuleList>? GetItems() => Items;

            public override void SetItems(List<AgentTargetingRuleList>? value) => Items = value;
        }
    }
}