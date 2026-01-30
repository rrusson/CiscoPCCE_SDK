using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("card")]
    public class Card : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("color")]
        public string? Color { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("header")]
        public string? Header { get; set; }

        [XmlElement("icon")]
        public string? Icon { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        public List<Menu>? Menus { get; set; }

        [XmlElement("systemDefined")]
        public bool? SystemDefined { get; set; }

        [XmlElement("uniqueId")]
        public string? UniqueId { get; set; }
    }
}