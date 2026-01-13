using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("agentdistribution")
    [XmlRoot("results")]
    public class AgentDistributionList : BaseApiList<AgentDistribution>
    {
        [XmlArray("agentDistributions")]
        [XmlArrayItem("agentDistribution")]
        public new List<AgentDistribution>? Items
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