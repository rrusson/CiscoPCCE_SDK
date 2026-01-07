using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("router")]
    public class WebsetupRouter : BaseApiBean
    {
        public string? EnabledPeripheralGateways { get; set; }

        public string? Side { get; set; }

        public string? SideAPrivateAddress { get; set; }

        public string? SideAPublicAddress { get; set; }

        public string? SideBPrivateAddress { get; set; }

        public string? SideBPublicAddress { get; set; }
    }
}