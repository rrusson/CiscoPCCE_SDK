using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("attribute")
    [XmlRoot("attribute")]
    public class Attribute : BaseApiBean
    {
        [XmlElement("agentAttributes")]
        [XmlElement("agentAttribute")]
        public List<AttributeValueWithAgent>? AgentAttributes { get; set; }

        [XmlElement("agentAttributesAdded")]
        [XmlElement("agentAttribute")]
        public List<AttributeValueWithAgent>? AgentAttributesAdded { get; set; }

        [XmlElement("agentAttributesRemoved")]
        [XmlElement("agentAttribute")]
        public List<AttributeValueWithAgent>? AgentAttributesRemoved { get; set; }

        public int? AgentCount { get; set; }

        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public int? DataType { get; set; }

        public string? DefaultValue { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? Description { get; set; }

        public string? IdFromRefUrl { get; set; }

        public bool? MarkDeletable { get; set; }

        public string? Name { get; set; }

        public new string? RefURL { get; set; }

        public int? SelectedAgentCount { get; set; }

        // Path("attribute")
        [XmlRoot("results")]
        public class AttributeList : BaseApiListBean<Attribute>
        {
            public override List<Attribute>? GetItems() => Items;

            public override void SetItems(List<Attribute>? value) => Items = value;
        }
    }
}