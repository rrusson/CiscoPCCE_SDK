using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("server")]
    public class CallServer : BaseApiBean
    {
        public string? Address { get; set; }

        public int? MessageBusNumber { get; set; }

        public int? Port { get; set; }

        public int? SubsystemNumber { get; set; }
    }
}