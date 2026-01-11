using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("agentdesksetting")
    [XmlRoot("results")]
    public class AgentDeskSettingList : BaseApiBean
    {
        [XmlArray("agentDeskSettings")]
        [XmlArrayItem("agentDeskSetting")]
        public List<AgentDeskSetting>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("agentdesksetting")
        [XmlRoot("results")]
        public class AgentDeskSettingListList : BaseApiListBean<AgentDeskSettingList>
        {
            [XmlArray("resultss")]
            [XmlArrayItem("results")]
            public new List<AgentDeskSettingList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<AgentDeskSettingList>? GetItems() => Items;

            public override void SetItems(List<AgentDeskSettingList>? value) => Items = value;
        }
    }
}