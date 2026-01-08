using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("/agentteam")
    [XmlRoot("agentTeamSummary")]
    public class AgentTeamSummary : BaseApiBean
    {
        [XmlElement("agentCount")]
        public int? AgentCount { get; set; }

        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("datacenter")]
        public required ReferenceBean Datacenter { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlElement("dialedNumber")]
        public required ReferenceBean DialedNumber { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("peripheral")]
        public required PeripheralRef Peripheral { get; set; }

        [XmlElement("peripheralId")]
        public int? PeripheralId { get; set; }

        [XmlElement("peripheralSet")]
        public required ReferenceBean PeripheralSet { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("supervisorCount")]
        public int? SupervisorCount { get; set; }

        // Path("/agentteam")
        [XmlRoot("results")]
        public class AgentTeamSummaryList : BaseApiListBean<AgentTeamSummary>
        {
            public override List<AgentTeamSummary>? GetItems() => Items;

            public override void SetItems(List<AgentTeamSummary>? value) => Items = value;
        }
    }
}