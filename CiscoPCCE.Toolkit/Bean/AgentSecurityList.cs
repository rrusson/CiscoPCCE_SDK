using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("agentsecurity")
    [XmlRoot("results")]
    public class AgentSecurityList : BaseApiList<AgentSecurity>
    {
        [XmlArray("agentSecuritys")]
        [XmlArrayItem("agentSecurity")]
        public new List<AgentSecurity>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}