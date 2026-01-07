using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("secondaryaddress")
    [XmlRoot("results")]
    public class PeripheralGatewayList : BaseApiBean
    {
        [XmlElement("peripheralGateways")]
        [XmlElement("peripheralGateway")]
        public List<PeripheralGateway>? Items { get; set; }

        public required PageInfo PageInfo { get; set; }

        public required PermissionInfo PermissionInfo { get; set; }

        // Path("secondaryaddress")
        [XmlRoot("results")]
        public class PeripheralGatewayListList : BaseApiListBean<PeripheralGatewayList>
        {
            public override List<PeripheralGatewayList>? GetItems() => Items;

            public override void SetItems(List<PeripheralGatewayList>? value) => Items = value;
        }
    }
}