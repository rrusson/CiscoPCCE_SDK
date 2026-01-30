using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("/agentteam")
    [XmlRoot("results")]
    public class AgentTeamSummaryList : BaseApiList<AgentTeamSummary>
    {
        [XmlArray("agentTeamSummarys")]
        [XmlArrayItem("agentTeamSummary")]
        public new List<AgentTeamSummary>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}