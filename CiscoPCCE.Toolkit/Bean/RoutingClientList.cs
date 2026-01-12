using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("secondaryaddress")
    [XmlRoot("results")]
    public class RoutingClientList : BaseApiList<RoutingClient>
    {
        [XmlArray("routingClients")]
        [XmlArrayItem("routingClient")]
        public new List<RoutingClient>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }
    }
}