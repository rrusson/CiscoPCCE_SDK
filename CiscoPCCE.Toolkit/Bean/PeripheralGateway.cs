using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("secondaryaddress")
    [XmlRoot("peripheralGateway")]
    public class PeripheralGateway : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("clientType")]
        public short? ClientType { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("datacenter")]
        public required ReferenceBean Datacenter { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("logicalControllerId")]
        public int? LogicalControllerId { get; set; }

        [XmlElement("logicalControllerType")]
        public short? LogicalControllerType { get; set; }

        [XmlElement("markDeletable")]
        public bool? MarkDeletable { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlArray("peripherals")]
        [XmlArrayItem("peripheral")]
        public List<PeripheralWithRoutingClient>? Peripherals { get; set; }

        [XmlElement("primaryCtiAddress")]
        public string? PrimaryCtiAddress { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("secondaryCtiAddress")]
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