using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("secondaryaddress")
    [XmlRoot("peripheral")]
    public class PeripheralWithRoutingClient : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("clientType")]
        public short? ClientType { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("defaultDeskSetting")]
        public required ReferenceBean DefaultDeskSetting { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("hideRefURL")]
        public bool? HideRefURL { get; set; }

        [XmlElement("hostName1")]
        public string? HostName1 { get; set; }

        [XmlElement("hostName2")]
        public string? HostName2 { get; set; }

        [XmlElement("hostPort1")]
        public int? HostPort1 { get; set; }

        [XmlElement("hostPort2")]
        public int? HostPort2 { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("markDeletable")]
        public bool? MarkDeletable { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("networkTarget")]
        public required ReferenceBean NetworkTarget { get; set; }

        [XmlElement("peripheralGateway")]
        public required ReferenceBean PeripheralGateway { get; set; }

        [XmlElement("peripheralId")]
        public int? PeripheralId { get; set; }

        [XmlElement("peripheralName")]
        public string? PeripheralName { get; set; }

        [XmlElement("routingClient")]
        public required RoutingClient RoutingClient { get; set; }

        [XmlElement("routingClientId")]
        public int? RoutingClientId { get; set; }

        [XmlElement("routingType")]
        public int? RoutingType { get; set; }

        [XmlElement("routingTypeForMROnDC")]
        public string? RoutingTypeForMROnDC { get; set; }

        // Path("secondaryaddress")
        [XmlRoot("results")]
        public class PeripheralWithRoutingClientList : BaseApiListBean<PeripheralWithRoutingClient>
        {
            [XmlArray("peripherals")]
            [XmlArrayItem("peripheral")]
            public new List<PeripheralWithRoutingClient>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<PeripheralWithRoutingClient>? GetItems() => Items;

            public override void SetItems(List<PeripheralWithRoutingClient>? value) => Items = value;
        }
    }
}