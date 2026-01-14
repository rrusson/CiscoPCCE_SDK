using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("callServers")]
    public class CallServers : BaseApiBean
    {
        [XmlArray("servers")]
        [XmlArrayItem("server")]
        public List<CallServer>? ServerList { get; set; }
    }
}