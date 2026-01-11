using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("/agentteam")
    [XmlRoot("results")]
    public class AgentTeamList : BaseApiBean
    {
        [XmlArray("agentTeams")]
        [XmlArrayItem("agentTeam")]
        public List<AgentTeamBase>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("/agentteam")
        [XmlRoot("results")]
        public class AgentTeamListList : BaseApiListBean<AgentTeamList>
        {
            [XmlArray("resultss")]
            [XmlArrayItem("results")]
            public new List<AgentTeamList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<AgentTeamList>? GetItems() => Items;

            public override void SetItems(List<AgentTeamList>? value) => Items = value;
        }
    }
}