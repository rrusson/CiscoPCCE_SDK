using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("routePatternConfigs")]
    public class RoutePatternConfig : BaseApiBean
    {
        [XmlElement("destinationHostOrIP")]
        public string? DestinationHostOrIP { get; set; }

        [XmlElement("enableSendCallsToOriginator")]
        public bool? EnableSendCallsToOriginator { get; set; }

        [XmlElement("rnaTimeoutInSeconds")]
        public int RnaTimeoutInSeconds { get; set; }

        [XmlElement("routePattern")]
        public string? RoutePattern { get; set; }
    }
}