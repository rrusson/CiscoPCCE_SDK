using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("registry")
    [XmlRoot("registry")]
    public class Registry : BaseApiBean
    {
        public int? AppGwEnabled { get; set; }

        public string? CgListenPort { get; set; }

        public int? ConapiEnabled { get; set; }

        public int? HdsType { get; set; }

        public bool? InstanceCreated { get; set; }

        public string? InstanceName { get; set; }

        public string? JtapiCUCMSubAddress { get; set; }

        public string? JtapiClientVersion { get; set; }

        public string? JtapiUser { get; set; }

        public string? Locale { get; set; }

        [XmlElement("mediaRoutingPeripherals")]
        [XmlElement("mediaRoutingPeripheral")]
        public List<PeripheralWithRoutingClient>? MediaRoutingPeripherals { get; set; }

        public string? MrPG { get; set; }

        public int? OutboundEnabled { get; set; }

        [XmlElement("peripheralGatewaysRegistries")]
        [XmlElement("peripheralGatewaysRegistry")]
        public List<PeripheralGatewaysRegistry>? PeripheralGatewaysRegistries { get; set; }

        public string? UcmPG { get; set; }

        public string? UcmPGTIPPort { get; set; }

        public string? UcmPGTOSPort { get; set; }

        public string? VruPG { get; set; }

        // Path("registry")
        [XmlRoot("results")]
        public class RegistryList : BaseApiListBean<Registry>
        {
            public override List<Registry>? GetItems() => Items;

            public override void SetItems(List<Registry>? value) => Items = value;
        }
    }
}