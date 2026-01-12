using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
// Path("logcollection")
[XmlRoot("results")]
public class LogCollectionList : BaseApiList<LogCollection>
{
    [XmlArray("logCollections")]
    [XmlArrayItem("logCollection")]
    public new List<LogCollection>? Items
    {
        get => base.Items;
        set => base.Items = value;
    }

    [XmlElement("permissionInfo")]
    public required PermissionInfo PermissionInfo { get; set; }
}
}
