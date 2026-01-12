using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("registry")
    [XmlRoot("registry")]
    public class Registry : BaseApiBean
    {
        [XmlElement("appGwEnabled")]
        public int? AppGwEnabled { get; set; }

        [XmlElement("cgListenPort")]
        public string? CgListenPort { get; set; }

        [XmlElement("conapiEnabled")]
        public int? ConapiEnabled { get; set; }

        [XmlElement("hdsType")]
        public int? HdsType { get; set; }

        [XmlElement("instanceCreated")]
        public bool? InstanceCreated { get; set; }

        [XmlElement("instanceName")]
        public string? InstanceName { get; set; }

        [XmlElement("jtapiCUCMSubAddress")]
        public string? JtapiCUCMSubAddress { get; set; }

        [XmlElement("jtapiClientVersion")]
        public string? JtapiClientVersion { get; set; }

        [XmlElement("jtapiUser")]
        public string? JtapiUser { get; set; }

        [XmlElement("locale")]
        public string? Locale { get; set; }

        [XmlArray("mediaRoutingPeripherals")]
        [XmlArrayItem("mediaRoutingPeripheral")]
        public List<PeripheralWithRoutingClient>? MediaRoutingPeripherals { get; set; }

        [XmlElement("mrPG")]
        public string? MrPG { get; set; }

        [XmlElement("outboundEnabled")]
        public int? OutboundEnabled { get; set; }

        [XmlArray("peripheralGatewaysRegistries")]
        [XmlArrayItem("peripheralGatewaysRegistry")]
        public List<PeripheralGatewaysRegistry>? PeripheralGatewaysRegistries { get; set; }

        [XmlElement("ucmPG")]
        public string? UcmPG { get; set; }

        [XmlElement("ucmPGTIPPort")]
        public string? UcmPGTIPPort { get; set; }

        [XmlElement("ucmPGTOSPort")]
        public string? UcmPGTOSPort { get; set; }

        [XmlElement("vruPG")]
        public string? VruPG { get; set; }
        
    }
}