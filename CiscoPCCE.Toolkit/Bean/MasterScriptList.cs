using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
// Path("masterscript")
[XmlRoot("results")]
public class MasterScriptList : BaseApiList<MasterScript>
{
    [XmlArray("masterScripts")]
    [XmlArrayItem("masterScript")]
    public new List<MasterScript>? Items
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
