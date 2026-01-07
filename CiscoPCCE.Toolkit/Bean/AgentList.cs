using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("agent")
    [XmlRoot("results")]
    public class AgentList : BaseApiBean
    {
        [XmlElement("agents")]
        [XmlElement("agent")]
        public List<AgentBase>? Items { get; set; }

        public required PageInfo PageInfo { get; set; }

        public required PermissionInfo PermissionInfo { get; set; }

        // Path("agent")
        [XmlRoot("results")]
        public class AgentListList : BaseApiListBean<AgentList>
        {
            public override List<AgentList>? GetItems() => Items;

            public override void SetItems(List<AgentList>? value) => Items = value;
        }
    }
}