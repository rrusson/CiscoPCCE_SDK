using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    public class ConnectionParametersGlobal : BaseApiBean
    {
        [XmlElement("heartBeat")]
        public required HeartBeat HeartBeat { get; set; }

        [XmlElement("maxErrors")]
        public int? MaxErrors { get; set; }

        [XmlElement("session")]
        public required Session Session { get; set; }

        [XmlElement("timeout")]
        public required Timeout Timeout { get; set; }
    }
}