using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class ApplicationGatewayConnection : BaseApiBean
    {
        [XmlElement("address")]
        public string? Address { get; set; }

        [XmlElement("heartBeat")]
        public required HeartBeat HeartBeat { get; set; }

        [XmlElement("inService")]
        public bool? InService { get; set; }

        [XmlElement("initializationData")]
        public string? InitializationData { get; set; }

        [XmlElement("maxErrors")]
        public int? MaxErrors { get; set; }

        [XmlElement("port")]
        public int? Port { get; set; }

        [XmlElement("session")]
        public required Session Session { get; set; }

        [XmlElement("side")]
        public ApplicationGatewayPreferredSide Side { get; set; }

        [XmlElement("timeout")]
        public required Timeout Timeout { get; set; }
    }
}