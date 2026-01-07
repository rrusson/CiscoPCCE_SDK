using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("secondaryaddress")
    [XmlRoot("peripheralGateway")]
    public class PeripheralGateway : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public short? ClientType { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Datacenter { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? IdFromRefUrl { get; set; }

        public int? LogicalControllerId { get; set; }

        public short? LogicalControllerType { get; set; }

        public bool? MarkDeletable { get; set; }

        public string? Name { get; set; }

        [XmlElement("peripherals")]
        [XmlElement("peripheral")]
        public List<PeripheralWithRoutingClient>? Peripherals { get; set; }

        public string? PrimaryCtiAddress { get; set; }

        public new string? RefURL { get; set; }

        public string? SecondaryCtiAddress { get; set; }

        // Path("secondaryaddress")
        [XmlRoot("results")]
        public class PeripheralGatewayList : BaseApiListBean<PeripheralGateway>
        {
            public override List<PeripheralGateway>? GetItems() => Items;

            public override void SetItems(List<PeripheralGateway>? value) => Items = value;
        }
    }
}