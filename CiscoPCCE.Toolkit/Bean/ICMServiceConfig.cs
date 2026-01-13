using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("icm")]
    public class ICMServiceConfig : BaseApiBean
    {
        [XmlElement("enableSecureVRU")]
        public bool? EnableSecureVRU { get; set; }

        [XmlElement("enableTrunkUtilization")]
        public bool? EnableTrunkUtilization { get; set; }

        [XmlElement("gatewaylist")]
        public string? Gatewaylist { get; set; }

        [XmlArray("gateways")]
        [XmlArrayItem("gateway")]
        public List<ReferenceBean>? Gateways { get; set; }

        [XmlElement("maxDNISLength")]
        public int? MaxDNISLength { get; set; }

        [XmlElement("maxGatewayPorts")]
        public int? MaxGatewayPorts { get; set; }

        [XmlElement("vruConnectionPort")]
        public int? VruConnectionPort { get; set; }
    }
}