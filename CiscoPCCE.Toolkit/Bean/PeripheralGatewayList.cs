using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("secondaryaddress")
    [XmlRoot("results")]
    public class PeripheralGatewayList : BaseApiList<PeripheralGateway>
    {
        [XmlArray("peripheralGateways")]
        [XmlArrayItem("peripheralGateway")]
        public new List<PeripheralGateway>? Items
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