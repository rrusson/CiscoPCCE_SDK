using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("callType")]
    public class CallType : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("bucketInterval")]
        public required ReferenceBean BucketInterval { get; set; }

        [XmlElement("id")]
        public int? CallTypeId { get; set; }

        [XmlElement("ccaiConfigID")]
        public string? CcaiConfigID { get; set; }

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

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlArray("##default")]
        [XmlArrayItem("scriptSchedule")]
        public List<ScriptSchedule>? ScriptSchedules { get; set; }

        [XmlElement("serviceLevelThreshold")]
        public int? ServiceLevelThreshold { get; set; }

        [XmlElement("serviceLevelType")]
        public int? ServiceLevelType { get; set; }
    }
}