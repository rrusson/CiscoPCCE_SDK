using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("layoutprofile")]
    public class LayoutProfile : BaseApiBean
    {
        [XmlElement("layoutXml")]
        public string? LayoutXml { get; set; }

        [XmlElement("layoutXmlName")]
        public string? LayoutXmlName { get; set; }
    }
}