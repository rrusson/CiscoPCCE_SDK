using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("/agentteam")
    [XmlRoot("results")]
    public class AgentTeamList : BaseApiWrappedList<AgentTeamBase>
    {
        [XmlArray("agentTeams")]
        [XmlArrayItem("agentTeam")]
        public new List<AgentTeamBase>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}