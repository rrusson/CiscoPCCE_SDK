using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("/agentteam")
    [XmlRoot("results")]
    public class AgentTeamList : BaseApiList<AgentTeam>
    {
        [XmlArray("agentTeams")]
        [XmlArrayItem("agentTeam")]
        public new List<AgentTeam>? Items
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