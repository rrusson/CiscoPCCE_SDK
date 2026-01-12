using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
// Path("enterpriseroute")
[XmlRoot("results")]
public class EnterpriseRouteList : BaseApiList<EnterpriseRoute>
{
    [XmlArray("enterpriseRoutes")]
    [XmlArrayItem("enterpriseRoute")]
    public new List<EnterpriseRoute>? Items
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
