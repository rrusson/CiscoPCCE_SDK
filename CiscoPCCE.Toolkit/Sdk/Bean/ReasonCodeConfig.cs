using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("ReasonCode")]
    public class ReasonCodeConfig : BaseApiBean
    {
        [XmlElement("active")]
        public bool? Active { get; set; }

        [XmlElement("category")]
        public string? Category { get; set; }

        [XmlElement("code")]
        public string? Code { get; set; }

        [XmlElement("forAll")]
        public string? ForAll { get; set; }

        [XmlElement("id")]
        public int Id { get; set; }

        [XmlElement("label")]
        public string? Label { get; set; }

        [XmlElement("lastmodified")]
        public long? Lastmodified { get; set; }

        [XmlElement("systemCode")]
        public bool? SystemCode { get; set; }

        [XmlElement("uri")]
        public string? Uri { get; set; }
    }
}