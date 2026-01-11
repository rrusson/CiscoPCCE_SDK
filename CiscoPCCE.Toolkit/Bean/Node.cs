using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("##default")]
    public class Node : BaseApiBean
    {
        [XmlElement("active")]
        public bool? Active { get; set; }

        [XmlElement("deviceType")]
        public string? DeviceType { get; set; }

        [XmlElement("hostName")]
        public string? HostName { get; set; }

        [XmlElement("ip")]
        public string? Ip { get; set; }
    }
}