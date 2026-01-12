using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
// Path("externalpage")
[XmlRoot("results")]
public class ExternalPageList : BaseApiList<ExternalPage>
{
    [XmlArray("externalpages")]
    [XmlArrayItem("externalpage")]
    public new List<ExternalPage>? Items
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
