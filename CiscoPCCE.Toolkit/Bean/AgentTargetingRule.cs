using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("agenttargetingrule")
    [XmlRoot("agentTargetingRule")]
    public class AgentTargetingRule : BaseApiBean
    {
        [XmlElement("ranges")]
        [XmlElement("range")]
        public List<AgentTargetingRuleRange>? AgentTargetingRuleRanges { get; set; }

        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? Description { get; set; }

        public string? Expression { get; set; }

        public string? IdFromRefUrl { get; set; }

        public string? Name { get; set; }

        public required PeripheralRef Peripheral { get; set; }

        public new string? RefURL { get; set; }

        [XmlElement("routingClients")]
        [XmlElement("routingClient")]
        public List<ReferenceBean>? RoutingClients { get; set; }

        public short? RuleType { get; set; }

        // Path("agenttargetingrule")
        [XmlRoot("results")]
        public class AgentTargetingRuleList : BaseApiListBean<AgentTargetingRule>
        {
            public override List<AgentTargetingRule>? GetItems() => Items;

            public override void SetItems(List<AgentTargetingRule>? value) => Items = value;
        }
    }
}