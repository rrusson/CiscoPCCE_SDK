using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("precisionqueue")
    [XmlRoot("precisionQueue")]
    public class PrecisionQueue : BaseApiBean
    {
        public int? AgentCount { get; set; }

        public int? AgentOrdering { get; set; }

        public string? Attribute1 { get; set; }

        public string? Attribute2 { get; set; }

        public string? Attribute3 { get; set; }

        public string? Attribute4 { get; set; }

        public string? Attribute5 { get; set; }

        public string? BaseUrlfromRefUrl { get; set; }

        public required ReferenceBean BucketInterval { get; set; }

        public int? CallOrdering { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? Description { get; set; }

        public string? IdFromRefUrl { get; set; }

        public bool? MarkDeletable { get; set; }

        public required ReferenceBean MediaRoutingDomain { get; set; }

        public string? Name { get; set; }

        [XmlElement("id")]
        public int? PrecisionQueueId { get; set; }

        public new string? RefURL { get; set; }

        public int? ServiceLevelThreshold { get; set; }

        public int? ServiceLevelType { get; set; }

        [XmlElement("skillGroups")]
        [XmlElement("skillGroup")]
        public List<SkillGroupWithPqId>? SkillGroups { get; set; }

        [XmlElement("steps")]
        [XmlElement("step")]
        public List<Step>? Steps { get; set; }

        // Path("precisionqueue")
        [XmlRoot("results")]
        public class PrecisionQueueList : BaseApiListBean<PrecisionQueue>
        {
            public override List<PrecisionQueue>? GetItems() => Items;

            public override void SetItems(List<PrecisionQueue>? value) => Items = value;
        }
    }
}