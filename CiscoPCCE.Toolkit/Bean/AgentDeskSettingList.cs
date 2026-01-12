using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
// Path("agentdesksetting")
[XmlRoot("results")]
public class AgentDeskSettingList : BaseApiList<AgentDeskSetting>
{
    [XmlArray("agentDeskSettings")]
    [XmlArrayItem("agentDeskSetting")]
    public new List<AgentDeskSetting>? Items
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
