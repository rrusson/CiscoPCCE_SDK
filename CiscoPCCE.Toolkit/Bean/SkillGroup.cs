using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("skillgroup")
    [XmlRoot("skillGroup")]
    public class SkillGroup : BaseApiBean
    {
        public int? AgentCount { get; set; }

        [XmlElement("agents")]
        [XmlElement("agent")]
        public List<ReferenceBean>? Agents { get; set; }

        [XmlElement("agentsAdded")]
        [XmlElement("agent")]
        public List<ReferenceBean>? AgentsAdded { get; set; }

        [XmlElement("agentsRemoved")]
        [XmlElement("agent")]
        public List<ReferenceBean>? AgentsRemoved { get; set; }

        public string? BaseUrlfromRefUrl { get; set; }

        public required ReferenceBean BucketInterval { get; set; }

        public required ReferenceBean CampaignRef { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Datacenter { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? Description { get; set; }

        public string? IdFromRefUrl { get; set; }

        public bool? MarkDeletable { get; set; }

        public required ReferenceBean MediaRoutingDomain { get; set; }

        public string? Name { get; set; }

        public required PeripheralRef Peripheral { get; set; }

        public int? PeripheralNumber { get; set; }

        [XmlElement("peripheralSet")]
        public required ReferenceBean PeripheralSet { get; set; }

        public new string? RefURL { get; set; }

        public int? SelectedAgentCount { get; set; }

        public int? ServiceLevelThreshold { get; set; }

        public int? ServiceLevelType { get; set; }

        // Path("skillgroup")
        [XmlRoot("results")]
        public class SkillGroupList : BaseApiListBean<SkillGroup>
        {
            public override List<SkillGroup>? GetItems() => Items;

            public override void SetItems(List<SkillGroup>? value) => Items = value;
        }
    }
}