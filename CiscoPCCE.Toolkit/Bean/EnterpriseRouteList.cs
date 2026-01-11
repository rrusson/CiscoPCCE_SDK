using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("enterpriseroute")
    [XmlRoot("results")]
    public class EnterpriseRouteList : BaseApiBean
    {
        [XmlArray("EnterpriseRoutes")]
        [XmlArrayItem("EnterpriseRoute")]
        public List<EnterpriseRoute>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("enterpriseroute")
        [XmlRoot("results")]
        public class EnterpriseRouteListList : BaseApiListBean<EnterpriseRouteList>
        {
            [XmlArray("resultss")]
            [XmlArrayItem("results")]
            public new List<EnterpriseRouteList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<EnterpriseRouteList>? GetItems() => Items;

            public override void SetItems(List<EnterpriseRouteList>? value) => Items = value;
        }
    }
}