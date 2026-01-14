using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("##default")]
    public class Collection : BaseApiBean
    {
        public List<CollectionValue>? CollectionValues { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlElement("groupPermission")]
        public string? GroupPermission { get; set; }

        [XmlElement("id")]
        public string? Id { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("origin")]
        public string? Origin { get; set; }

        [XmlElement("type")]
        public string? Type { get; set; }

        [XmlElement("version")]
        public int? Version { get; set; }
    }
}