using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class DataSourceAddressRef : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("hostName")]
        public string? HostName { get; set; }

        [XmlElement("id")]
        public int? Id { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

    }
}