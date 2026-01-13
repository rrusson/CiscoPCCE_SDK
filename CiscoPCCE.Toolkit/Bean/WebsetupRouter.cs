using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("router")]
    public class WebsetupRouter : BaseApiBean
    {
        [XmlElement("enabledPeripheralGateways")]
        public string? EnabledPeripheralGateways { get; set; }

        [XmlElement("side")]
        public string? Side { get; set; }

        [XmlElement("sideAPrivateAddress")]
        public string? SideAPrivateAddress { get; set; }

        [XmlElement("sideAPublicAddress")]
        public string? SideAPublicAddress { get; set; }

        [XmlElement("sideBPrivateAddress")]
        public string? SideBPrivateAddress { get; set; }

        [XmlElement("sideBPublicAddress")]
        public string? SideBPublicAddress { get; set; }
    }
}