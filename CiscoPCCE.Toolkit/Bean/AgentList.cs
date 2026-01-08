using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("agent")
    [XmlRoot("results")]
    public class AgentList : BaseApiBean
    {
        [XmlArray("agents")]
        [XmlArrayItem("agent")]
        public List<AgentBase>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("agent")
        [XmlRoot("results")]
        public class AgentListList : BaseApiListBean<AgentList>
        {
            [XmlArray("resultss")]
            [XmlArrayItem("results")]
            public new List<AgentList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<AgentList>? GetItems() => Items;

            public override void SetItems(List<AgentList>? value) => Items = value;
        }
    }
}