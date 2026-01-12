using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
// Path("machineinventory")
[XmlRoot("results")]
public class MachineHostList : BaseApiList<MachineHost>
{
    [XmlArray("machines")]
    [XmlArrayItem("machine")]
    public new List<MachineHost>? Items
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
