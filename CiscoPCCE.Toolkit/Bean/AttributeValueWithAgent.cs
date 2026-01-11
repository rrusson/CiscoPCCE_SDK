using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class AttributeValueWithAgent : BaseApiBean
    {
        [XmlElement("agent")]
        public required ReferenceBean Agent { get; set; }

        [XmlElement("attributeValue")]
        public string? AttributeValue { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }
    }
}