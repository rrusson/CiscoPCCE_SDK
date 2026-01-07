using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("secondaryaddress")
    [XmlRoot("results")]
    public class RoutingClientList : BaseApiBean
    {
        [XmlElement("routingClients")]
        [XmlElement("routingClient")]
        public List<RoutingClient>? Items { get; set; }

        public required PageInfo PageInfo { get; set; }

        public required PermissionInfo PermissionInfo { get; set; }

        // Path("secondaryaddress")
        [XmlRoot("results")]
        public class RoutingClientListList : BaseApiListBean<RoutingClientList>
        {
            public override List<RoutingClientList>? GetItems() => Items;

            public override void SetItems(List<RoutingClientList>? value) => Items = value;
        }
    }
}