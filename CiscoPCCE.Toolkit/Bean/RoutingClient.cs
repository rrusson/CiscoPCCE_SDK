using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("secondaryaddress")
    [XmlRoot("routingClient")]
    public class RoutingClient : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("clientType")]
        public short? ClientType { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("lateThreshold")]
        public short? LateThreshold { get; set; }

        [XmlElement("logicalController")]
        public required ReferenceBean LogicalController { get; set; }

        [XmlElement("markDeletable")]
        public bool? MarkDeletable { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("peripheral")]
        public required PeripheralRef Peripheral { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("timeoutLimit")]
        public short? TimeoutLimit { get; set; }

        [XmlElement("timeoutThreshold")]
        public short? TimeoutThreshold { get; set; }

        // Path("secondaryaddress")
        [XmlRoot("results")]
        public class RoutingClientList : BaseApiListBean<RoutingClient>
        {
            [XmlArray("routingClients")]
            [XmlArrayItem("routingClient")]
            public new List<RoutingClient>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<RoutingClient>? GetItems() => Items;

            public override void SetItems(List<RoutingClient>? value) => Items = value;
        }
    }
}