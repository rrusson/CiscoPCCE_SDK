using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("callServers")]
    public class CallServers : BaseApiBean
    {
        [XmlElement("servers")]
        [XmlElement("server")]
        public List<CallServer>? ServerList { get; set; }
    }
}