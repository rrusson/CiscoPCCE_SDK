using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("secondaryaddress")
    [XmlRoot("routingClient")]
    public class RoutingClient : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public short? ClientType { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? IdFromRefUrl { get; set; }

        public short? LateThreshold { get; set; }

        public required ReferenceBean LogicalController { get; set; }

        public bool? MarkDeletable { get; set; }

        public string? Name { get; set; }

        public required PeripheralRef Peripheral { get; set; }

        public new string? RefURL { get; set; }

        public short? TimeoutLimit { get; set; }

        public short? TimeoutThreshold { get; set; }

        // Path("secondaryaddress")
        [XmlRoot("results")]
        public class RoutingClientList : BaseApiListBean<RoutingClient>
        {
            public override List<RoutingClient>? GetItems() => Items;

            public override void SetItems(List<RoutingClient>? value) => Items = value;
        }
    }
}