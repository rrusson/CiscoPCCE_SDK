using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("realTimeStatus")]
    public class BusinessHourRealTimeStatus : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("status")]
        public int? Status { get; set; }

        [XmlElement("statusReason")]
        public required ReferenceBean StatusReason { get; set; }
    }
}