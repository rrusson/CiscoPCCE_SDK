using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("agenttargetingrule")
    [XmlRoot("results")]
    public class AgentTargetingRuleList : BaseApiWrappedList<AgentTargetingRule>
    {
        [XmlArray("agentTargetingRules")]
        [XmlArrayItem("agentTargetingRule")]
        public new List<AgentTargetingRule>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}