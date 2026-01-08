using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("agentdistribution")
    [XmlRoot("results")]
    public class AgentDistributionList : BaseApiBean
    {
        [XmlArray("agentDistributions")]
        [XmlArrayItem("agentDistribution")]
        public List<AgentDistribution>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        // Path("agentdistribution")
        [XmlRoot("results")]
        public class AgentDistributionListList : BaseApiListBean<AgentDistributionList>
        {
            public override List<AgentDistributionList>? GetItems() => Items;

            public override void SetItems(List<AgentDistributionList>? value) => Items = value;
        }
    }
}