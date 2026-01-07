using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("applicationgatewayglobalsetting")
    [XmlRoot("results")]
    public class ApplicationGatewayGlobalsList : BaseApiBean
    {
        [XmlElement("applicationGatewayGlobalSettings")]
        [XmlElement("applicationGatewayGlobalSetting")]
        public List<ApplicationGatewayGlobals>? Items { get; set; }

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