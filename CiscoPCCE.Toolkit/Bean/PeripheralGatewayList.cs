using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("secondaryaddress")
    [XmlRoot("results")]
    public class PeripheralGatewayList : BaseApiBean
    {
        [XmlArray("peripheralGateways")]
        [XmlArrayItem("peripheralGateway")]
        public List<PeripheralGateway>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("secondaryaddress")
        [XmlRoot("results")]
        public class PeripheralGatewayListList : BaseApiListBean<PeripheralGatewayList>
        {
            [XmlArray("resultss")]
            [XmlArrayItem("results")]
            public new List<PeripheralGatewayList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<PeripheralGatewayList>? GetItems() => Items;

            public override void SetItems(List<PeripheralGatewayList>? value) => Items = value;
        }
    }
}