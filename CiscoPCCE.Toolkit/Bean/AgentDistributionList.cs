using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

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
            [XmlArray("resultss")]
            [XmlArrayItem("results")]
            public new List<AgentDistributionList>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<AgentDistributionList>? GetItems() => Items;

            public override void SetItems(List<AgentDistributionList>? value) => Items = value;
        }
    }
}