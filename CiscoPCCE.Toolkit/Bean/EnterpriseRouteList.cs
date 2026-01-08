using System.Xml.Serialization;

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
            public override List<EnterpriseRouteList>? GetItems() => Items;

            public override void SetItems(List<EnterpriseRouteList>? value) => Items = value;
        }
    }
}