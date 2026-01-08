using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("applicationgatewayglobalsetting")
    [XmlRoot("results")]
    public class ApplicationGatewayGlobalsList : BaseApiBean
    {
        [XmlArray("applicationGatewayGlobalSettings")]
        [XmlArrayItem("applicationGatewayGlobalSetting")]
        public List<ApplicationGatewayGlobals>? Items { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("applicationgatewayglobalsetting")
        [XmlRoot("results")]
        public class ApplicationGatewayGlobalsListList : BaseApiListBean<ApplicationGatewayGlobalsList>
        {
            public override List<ApplicationGatewayGlobalsList>? GetItems() => Items;

            public override void SetItems(List<ApplicationGatewayGlobalsList>? value) => Items = value;
        }
    }
}