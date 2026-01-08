using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("agenttargetingrule")
    [XmlRoot("agentTargetingRule")]
    public class AgentTargetingRule : BaseApiBean
    {
        [XmlArray("ranges")]
        [XmlArrayItem("range")]
        public List<AgentTargetingRuleRange>? AgentTargetingRuleRanges { get; set; }

        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlElement("expression")]
        public string? Expression { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("peripheral")]
        public required PeripheralRef Peripheral { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlArray("routingClients")]
        [XmlArrayItem("routingClient")]
        public List<ReferenceBean>? RoutingClients { get; set; }

        [XmlElement("ruleType")]
        public short? RuleType { get; set; }

        // Path("agenttargetingrule")
        [XmlRoot("results")]
        public class AgentTargetingRuleList : BaseApiListBean<AgentTargetingRule>
        {
            [XmlArray("agentTargetingRules")]
            [XmlArrayItem("agentTargetingRule")]
            public new List<AgentTargetingRule>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<AgentTargetingRule>? GetItems() => Items;

            public override void SetItems(List<AgentTargetingRule>? value) => Items = value;
        }
    }
}