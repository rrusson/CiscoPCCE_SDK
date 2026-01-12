using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("sipservergroup")
    [XmlRoot("element")]
    public class SipServerElement : BaseApiBean
    {
        [XmlElement("address")]
        public string? Address { get; set; }

        [XmlElement("dataCenter")]
        public required ReferenceBean DataCenter { get; set; }

        [XmlElement("port")]
        public string? Port { get; set; }

        [XmlElement("priority")]
        public string? Priority { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("securePort")]
        public string? SecurePort { get; set; }

        [XmlElement("weight")]
        public string? Weight { get; set; }
        
    }
}