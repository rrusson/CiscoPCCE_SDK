using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("agentdesksetting")
    [XmlRoot("results")]
    public class AgentDeskSettingList : BaseApiWrappedList<AgentDeskSetting>
    {
        [XmlArray("agentDeskSettings")]
        [XmlArrayItem("agentDeskSetting")]
        public new List<AgentDeskSetting>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}