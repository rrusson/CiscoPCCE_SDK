using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

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
            [XmlArray("resultss")]
            [XmlArrayItem("results")]
            public new List<ApplicationGatewayGlobalsList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<ApplicationGatewayGlobalsList>? GetItems() => Items;

            public override void SetItems(List<ApplicationGatewayGlobalsList>? value) => Items = value;
        }
    }
}