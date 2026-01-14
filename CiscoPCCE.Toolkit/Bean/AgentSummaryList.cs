using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("agent")
    [XmlRoot("results")]
    public class AgentSummaryList : BaseApiList<AgentSummary>
    {
        [XmlArray("agentSummarys")]
        [XmlArrayItem("agentSummary")]
        public new List<AgentSummary>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}