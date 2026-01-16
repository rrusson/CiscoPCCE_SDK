using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("Feed")]
    public class Feed : BaseApiBean
    {
        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlArray("tags")]
        [XmlArrayItem("tag")]
        public List<string?>? Tags { get; set; }

        [XmlElement("type")]
        public int? Type { get; set; }
    }
}