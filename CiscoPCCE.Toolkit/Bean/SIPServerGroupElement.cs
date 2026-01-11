using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("sipServerGroupElements")]
    public class SIPServerGroupElement : BaseApiBean
    {
        [XmlElement("elementName")]
        public string? ElementName { get; set; }

        [XmlElement("port")]
        public string? Port { get; set; }

        [XmlElement("priority")]
        public string? Priority { get; set; }

        [XmlElement("securePort")]
        public string? SecurePort { get; set; }

        [XmlElement("weight")]
        public string? Weight { get; set; }
    }
}