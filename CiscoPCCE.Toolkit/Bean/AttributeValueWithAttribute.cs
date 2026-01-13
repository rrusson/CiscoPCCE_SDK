using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class AttributeValueWithAttribute : BaseApiBean
    {
        [XmlElement("attribute")]
        public required ReferenceBean Attribute { get; set; }

        [XmlElement("attributeValue")]
        public string? AttributeValue { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }
    }
}