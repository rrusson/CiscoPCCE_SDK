using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("reference")]
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