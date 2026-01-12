using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
// Path("routingpattern")
[XmlRoot("results")]
public class RoutingPatternList : BaseApiList<RoutingPattern>
{
    [XmlArray("routingPatterns")]
    [XmlArrayItem("routingPattern")]
    public new List<RoutingPattern>? Items
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
