using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("/agentteam")
    public class AgentTeamBase : BaseApiBean
    {
        public int? AgentCount { get; set; }

        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Datacenter { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? Description { get; set; }

        public required ReferenceBean DialedNumber { get; set; }

        public string? IdFromRefUrl { get; set; }

        public string? Name { get; set; }

        public required PeripheralRef Peripheral { get; set; }

        public int? PeripheralId { get; set; }

        [XmlElement("peripheralSet")]
        public required ReferenceBean PeripheralSet { get; set; }

        public new string? RefURL { get; set; }

        public int? SupervisorCount { get; set; }
    }
}