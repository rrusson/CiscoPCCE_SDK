using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("skillgroup")
    [XmlRoot("skillGroupSummary")]
    public class SkillGroupSummary : BaseApiBean
    {
        [XmlElement("agentCount")]
        public int? AgentCount { get; set; }

        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("datacenter")]
        public required ReferenceBean Datacenter { get; set; }

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

        [XmlElement("peripheral")]
        public required PeripheralRef Peripheral { get; set; }

        [XmlElement("peripheralNumber")]
        public int? PeripheralNumber { get; set; }

        [XmlElement("peripheralSet")]
        public required ReferenceBean PeripheralSet { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("selectedAgentCount")]
        public int? SelectedAgentCount { get; set; }

        // Path("skillgroup")
        [XmlRoot("results")]
        public class SkillGroupSummaryList : BaseApiListBean<SkillGroupSummary>
        {
            public override List<SkillGroupSummary>? GetItems() => Items;

            public override void SetItems(List<SkillGroupSummary>? value) => Items = value;
        }
    }
}