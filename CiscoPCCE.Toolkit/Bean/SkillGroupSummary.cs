using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("skillgroup")
    [XmlRoot("skillGroupSummary")]
    public class SkillGroupSummary : BaseApiBean
    {
        public int? AgentCount { get; set; }

        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Datacenter { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? Description { get; set; }

        public string? IdFromRefUrl { get; set; }

        public bool? MarkDeletable { get; set; }

        public string? Name { get; set; }

        public required PeripheralRef Peripheral { get; set; }

        public int? PeripheralNumber { get; set; }

        [XmlElement("peripheralSet")]
        public required ReferenceBean PeripheralSet { get; set; }

        public new string? RefURL { get; set; }

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