using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("agentdistribution")
    [XmlRoot("results")]
    public class AgentDistributionList : BaseApiWrappedList<AgentDistribution>
    {
        [XmlArray("agentDistributions")]
        [XmlArrayItem("agentDistribution")]
        public new List<AgentDistribution>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}