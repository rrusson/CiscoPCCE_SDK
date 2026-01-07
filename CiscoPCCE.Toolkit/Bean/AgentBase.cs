using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("agent")
    public class AgentBase : BaseApiBean
    {
        public string? AgentId { get; set; }

        [XmlElement("agentServicesEnabled")]
        [XmlElement("agentService")]
        public List<AgentServiceEnabled>? AgentServicesEnabled { get; set; }

        [XmlElement("agentServicesToDisable")]
        [XmlElement("agentService")]
        public List<AgentServiceEnabled>? AgentServicesToDisable { get; set; }

        [XmlElement("agentServicesToEnable")]
        [XmlElement("agentService")]
        public List<AgentServiceEnabled>? AgentServicesToEnable { get; set; }

        public bool? AgentStateTrace { get; set; }

        public required ReferenceBean AgentTeam { get; set; }

        public string? AttributeValue { get; set; }

        public string? BaseUrlfromRefUrl { get; set; }

        public bool? CanRemove { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? ConfigParam { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Datacenter { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? Description { get; set; }

        public string? IdFromRefUrl { get; set; }

        public bool? MarkDeletable { get; set; }

        public string? Name { get; set; }

        public required PeripheralRef Peripheral { get; set; }

        public string? PeripheralName { get; set; }

        [XmlElement("peripheralSet")]
        public required ReferenceBean PeripheralSet { get; set; }

        public required Person Person { get; set; }

        public new string? RefURL { get; set; }

        public bool? SelectedAttribute { get; set; }

        public bool? SelectedSkillGroup { get; set; }

        public bool? Supervisor { get; set; }
    }
}