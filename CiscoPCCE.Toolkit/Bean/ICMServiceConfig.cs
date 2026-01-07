using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("icm")]
    public class ICMServiceConfig : BaseApiBean
    {
        public bool? EnableSecureVRU { get; set; }

        public bool? EnableTrunkUtilization { get; set; }

        public string? Gatewaylist { get; set; }

        [XmlElement("gateways")]
        [XmlElement("gateway")]
        public List<ReferenceBean>? Gateways { get; set; }

        public int? MaxDNISLength { get; set; }

        public int? MaxGatewayPorts { get; set; }

        public int? VruConnectionPort { get; set; }
    }
}