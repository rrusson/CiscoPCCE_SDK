using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("secondaryaddress")
    [XmlRoot("peripheral")]
    public class PeripheralWithRoutingClient : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public short? ClientType { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean DefaultDeskSetting { get; set; }

        public required ReferenceBean Department { get; set; }

        public bool? HideRefURL { get; set; }

        public string? HostName1 { get; set; }

        public string? HostName2 { get; set; }

        public int? HostPort1 { get; set; }

        public int? HostPort2 { get; set; }

        public string? IdFromRefUrl { get; set; }

        public bool? MarkDeletable { get; set; }

        public string? Name { get; set; }

        public required ReferenceBean NetworkTarget { get; set; }

        public required ReferenceBean PeripheralGateway { get; set; }

        public int? PeripheralId { get; set; }

        public string? PeripheralName { get; set; }

        public required RoutingClient RoutingClient { get; set; }

        public int? RoutingClientId { get; set; }

        public int? RoutingType { get; set; }

        public string? RoutingTypeForMROnDC { get; set; }

        // Path("secondaryaddress")
        [XmlRoot("results")]
        public class PeripheralWithRoutingClientList : BaseApiListBean<PeripheralWithRoutingClient>
        {
            public override List<PeripheralWithRoutingClient>? GetItems() => Items;

            public override void SetItems(List<PeripheralWithRoutingClient>? value) => Items = value;
        }
    }
}