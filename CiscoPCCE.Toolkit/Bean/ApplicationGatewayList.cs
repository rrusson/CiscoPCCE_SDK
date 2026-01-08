using System.Xml.Serialization;

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
            public override List<ApplicationGatewayList>? GetItems() => Items;

            public override void SetItems(List<ApplicationGatewayList>? value) => Items = value;
        }
    }
}