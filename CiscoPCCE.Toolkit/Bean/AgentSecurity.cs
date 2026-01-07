using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("agentsecurity")
    [XmlRoot("agentSecurity")]
    public class AgentSecurity : BaseApiBean
    {
        public int? AgentsWithoutAdvancedHashing { get; set; }

        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public bool? EnforceAdvancedHashing { get; set; }

        public string? IdFromRefUrl { get; set; }

        public new string? RefURL { get; set; }

        public int? UnsupportedPeripheralGateways { get; set; }

        // Path("agentsecurity")
        [XmlRoot("results")]
        public class AgentSecurityList : BaseApiListBean<AgentSecurity>
        {
            public override List<AgentSecurity>? GetItems() => Items;

            public override void SetItems(List<AgentSecurity>? value) => Items = value;
        }
    }
}