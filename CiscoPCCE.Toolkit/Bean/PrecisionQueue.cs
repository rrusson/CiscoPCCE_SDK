using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("precisionqueue")
    [XmlRoot("precisionQueue")]
    public class PrecisionQueue : BaseApiBean
    {
        [XmlElement("agentCount")]
        public int? AgentCount { get; set; }

        [XmlElement("agentOrdering")]
        public int? AgentOrdering { get; set; }

        [XmlElement("attribute1")]
        public string? Attribute1 { get; set; }

        [XmlElement("attribute2")]
        public string? Attribute2 { get; set; }

        [XmlElement("attribute3")]
        public string? Attribute3 { get; set; }

        [XmlElement("attribute4")]
        public string? Attribute4 { get; set; }

        [XmlElement("attribute5")]
        public string? Attribute5 { get; set; }

        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("bucketInterval")]
        public required ReferenceBean BucketInterval { get; set; }

        [XmlElement("callOrdering")]
        public int? CallOrdering { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("markDeletable")]
        public bool? MarkDeletable { get; set; }

        [XmlElement("mediaRoutingDomain")]
        public required ReferenceBean MediaRoutingDomain { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("id")]
        public int? PrecisionQueueId { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("serviceLevelThreshold")]
        public int? ServiceLevelThreshold { get; set; }

        [XmlElement("serviceLevelType")]
        public int? ServiceLevelType { get; set; }

        [XmlArray("skillGroups")]
        [XmlArrayItem("skillGroup")]
        public List<SkillGroupWithPqId>? SkillGroups { get; set; }

        [XmlArray("steps")]
        [XmlArrayItem("step")]
        public List<Step>? Steps { get; set; }
    }
}