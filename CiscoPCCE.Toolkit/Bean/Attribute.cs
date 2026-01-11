using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("attribute")
    [XmlRoot("attribute")]
    public class Attribute : BaseApiBean
    {
        [XmlArray("agentAttributes")]
        [XmlArrayItem("agentAttribute")]
        public List<AttributeValueWithAgent>? AgentAttributes { get; set; }

        [XmlArray("agentAttributesAdded")]
        [XmlArrayItem("agentAttribute")]
        public List<AttributeValueWithAgent>? AgentAttributesAdded { get; set; }

        [XmlArray("agentAttributesRemoved")]
        [XmlArrayItem("agentAttribute")]
        public List<AttributeValueWithAgent>? AgentAttributesRemoved { get; set; }

        [XmlElement("agentCount")]
        public int? AgentCount { get; set; }

        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("dataType")]
        public int? DataType { get; set; }

        [XmlElement("defaultValue")]
        public string? DefaultValue { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("markDeletable")]
        public bool? MarkDeletable { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("selectedAgentCount")]
        public int? SelectedAgentCount { get; set; }

        // Path("attribute")
        [XmlRoot("results")]
        public class AttributeList : BaseApiListBean<Attribute>
        {
            [XmlArray("attributes")]
            [XmlArrayItem("attribute")]
            public new List<Attribute>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<Attribute>? GetItems() => Items;

            public override void SetItems(List<Attribute>? value) => Items = value;
        }
    }
}