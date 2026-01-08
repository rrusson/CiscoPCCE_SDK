using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("reference")]
    public class MarkDeleteReference : BaseApiBean
    {
        [XmlElement("deleted")]
        public bool? Deleted { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }
    }
}