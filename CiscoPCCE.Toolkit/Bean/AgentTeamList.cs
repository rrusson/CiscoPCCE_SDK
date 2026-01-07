using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("/agentteam")
    [XmlRoot("results")]
    public class AgentTeamList : BaseApiBean
    {
        [XmlElement("agentTeams")]
        [XmlElement("agentTeam")]
        public List<AgentTeamBase>? Items { get; set; }

        public required PageInfo PageInfo { get; set; }

        public required PermissionInfo PermissionInfo { get; set; }

        // Path("/agentteam")
        [XmlRoot("results")]
        public class AgentTeamListList : BaseApiListBean<AgentTeamList>
        {
            public override List<AgentTeamList>? GetItems() => Items;

            public override void SetItems(List<AgentTeamList>? value) => Items = value;
        }
    }
}