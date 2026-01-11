using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("secondaryaddress")
    [XmlRoot("results")]
    public class RoutingClientList : BaseApiBean
    {
        [XmlArray("routingClients")]
        [XmlArrayItem("routingClient")]
        public List<RoutingClient>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("secondaryaddress")
        [XmlRoot("results")]
        public class RoutingClientListList : BaseApiListBean<RoutingClientList>
        {
            [XmlArray("resultss")]
            [XmlArrayItem("results")]
            public new List<RoutingClientList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<RoutingClientList>? GetItems() => Items;

            public override void SetItems(List<RoutingClientList>? value) => Items = value;
        }
    }
}