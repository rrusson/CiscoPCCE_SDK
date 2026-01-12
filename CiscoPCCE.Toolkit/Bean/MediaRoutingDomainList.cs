using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
// Path("mediaroutingdomain")
[XmlRoot("results")]
public class MediaRoutingDomainList : BaseApiList<MediaRoutingDomain>
{
    [XmlArray("mediaRoutingDomains")]
    [XmlArrayItem("mediaRoutingDomain")]
    public new List<MediaRoutingDomain>? Items
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
