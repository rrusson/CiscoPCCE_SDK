using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("administrator")]
    public class Administrator : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("customer")]
        public required ReferenceBean Customer { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlArray("departments")]
        [XmlArrayItem("department")]
        public List<ReferenceBean>? Departments { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlElement("domainName")]
        public string? DomainName { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("readOnly")]
        public bool? ReadOnly { get; set; }

        [XmlElement("role")]
        public required ReferenceBean Role { get; set; }

        [XmlElement("ssoEnabled")]
        public bool? SsoEnabled { get; set; }

        [XmlElement("supervisor")]
        public bool? Supervisor { get; set; }

        [XmlElement("userName")]
        public string? UserName { get; set; }
    }
}