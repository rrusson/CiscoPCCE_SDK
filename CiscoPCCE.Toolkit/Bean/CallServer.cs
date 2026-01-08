using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("server")]
    public class CallServer : BaseApiBean
    {
        [XmlElement("address")]
        public string? Address { get; set; }

        [XmlElement("messageBusNumber")]
        public int? MessageBusNumber { get; set; }

        [XmlElement("port")]
        public int? Port { get; set; }

        [XmlElement("subsystemNumber")]
        public int? SubsystemNumber { get; set; }
    }
}