using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("applicationgateway")
    [XmlRoot("results")]
    public class ApplicationGatewayList : BaseApiBean
    {
        [XmlArray("applicationGateways")]
        [XmlArrayItem("applicationGateway")]
        public List<ApplicationGateway>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("applicationgateway")
        [XmlRoot("results")]
        public class ApplicationGatewayListList : BaseApiListBean<ApplicationGatewayList>
        {
            [XmlArray("resultss")]
            [XmlArrayItem("results")]
            public new List<ApplicationGatewayList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<ApplicationGatewayList>? GetItems() => Items;

            public override void SetItems(List<ApplicationGatewayList>? value) => Items = value;
        }
    }
}