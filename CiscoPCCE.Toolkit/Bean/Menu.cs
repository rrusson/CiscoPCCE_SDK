using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("menu")]
    public class Menu : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public required ReferenceBean Card { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        [XmlElement("features")]
        [XmlElement("feature")]
        public List<Feature>? Features { get; set; }

        public bool? Hidden { get; set; }

        public string? IdFromRefUrl { get; set; }

        public string? Name { get; set; }

        public string? Path { get; set; }

        public new string? RefURL { get; set; }

        public bool? SystemDefined { get; set; }

        public string? UniqueId { get; set; }
    }
}