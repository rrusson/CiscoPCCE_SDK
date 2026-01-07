using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("agentdistribution")
    [XmlRoot("agentDistribution")]
    public class AgentDistribution : BaseApiBean
    {
        public bool? AgentHistoricalData { get; set; }

        public bool? AgentRealTimeData { get; set; }

        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? IdFromRefUrl { get; set; }

        public string? Name { get; set; }

        public int? PeripheralId { get; set; }

        public new string? RefURL { get; set; }

        // Path("agentdistribution")
        [XmlRoot("results")]
        public class AgentDistributionList : BaseApiListBean<AgentDistribution>
        {
            public override List<AgentDistribution>? GetItems() => Items;

            public override void SetItems(List<AgentDistribution>? value) => Items = value;
        }
    }
}