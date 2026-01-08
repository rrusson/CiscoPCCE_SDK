using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    public class CallGlobalSetting : BaseApiBean
    {
        [XmlElement("abandonCallWaitTime")]
        public short? AbandonCallWaitTime { get; set; }

        [XmlElement("answeredShortCallThreshold")]
        public int? AnsweredShortCallThreshold { get; set; }

        [XmlElement("baseUrl")]
        public string? BaseUrl { get; set; }

        [XmlElement("defaultBucketInterval")]
        public required ReferenceBean DefaultBucketInterval { get; set; }

        [XmlElement("defaultCallType")]
        public required ReferenceBean DefaultCallType { get; set; }

        [XmlElement("serviceLevelThreshold")]
        public int? ServiceLevelThreshold { get; set; }

        [XmlElement("serviceLevelType")]
        public short? ServiceLevelType { get; set; }
    }
}