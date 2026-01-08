using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("reference")]
    public class ReferenceWithId : BaseApiBean
    {
        [XmlElement("deleted")]
        public bool? Deleted { get; set; }

        [XmlElement("id")]
        public int? Id { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }
    }
}