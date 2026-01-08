using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("agenttargetingrule")
    [XmlRoot("range")]
    public class AgentTargetingRuleRange : BaseApiBean
    {
        [XmlElement("highExtension")]
        public string? HighExtension { get; set; }

        [XmlElement("lowExtension")]
        public string? LowExtension { get; set; }

        // Path("agenttargetingrule")
        [XmlRoot("results")]
        public class AgentTargetingRuleRangeList : BaseApiListBean<AgentTargetingRuleRange>
        {
            public override List<AgentTargetingRuleRange>? GetItems() => Items;

            public override void SetItems(List<AgentTargetingRuleRange>? value) => Items = value;
        }
    }
}