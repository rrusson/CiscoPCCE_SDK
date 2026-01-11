using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("menu")]
    public class Menu : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("card")]
        public required ReferenceBean Card { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlArray("features")]
        [XmlArrayItem("feature")]
        public List<Feature>? Features { get; set; }

        [XmlElement("hidden")]
        public bool? Hidden { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("path")]
        public string? Path { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("systemDefined")]
        public bool? SystemDefined { get; set; }

        [XmlElement("uniqueId")]
        public string? UniqueId { get; set; }
    }
}