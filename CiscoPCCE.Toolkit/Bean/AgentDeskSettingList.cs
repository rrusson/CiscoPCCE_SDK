using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("agentdesksetting")
    [XmlRoot("results")]
    public class AgentDeskSettingList : BaseApiBean
    {
        [XmlElement("agentDeskSettings")]
        [XmlElement("agentDeskSetting")]
        public List<AgentDeskSetting>? Items { get; set; }

        public required PageInfo PageInfo { get; set; }

        public required PermissionInfo PermissionInfo { get; set; }

        // Path("agentdesksetting")
        [XmlRoot("results")]
        public class AgentDeskSettingListList : BaseApiListBean<AgentDeskSettingList>
        {
            public override List<AgentDeskSettingList>? GetItems() => Items;

            public override void SetItems(List<AgentDeskSettingList>? value) => Items = value;
        }
    }
}