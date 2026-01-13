using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("agentSummary")]
    public class AgentSummary : BaseApiBean
    {
        [XmlElement("agentId")]
        public string? AgentId { get; set; }

        [XmlArray("agentServicesEnabled")]
        [XmlArrayItem("agentService")]
        public List<AgentServiceEnabled>? AgentServicesEnabled { get; set; }

        [XmlArray("agentServicesToDisable")]
        [XmlArrayItem("agentService")]
        public List<AgentServiceEnabled>? AgentServicesToDisable { get; set; }

        [XmlArray("agentServicesToEnable")]
        [XmlArrayItem("agentService")]
        public List<AgentServiceEnabled>? AgentServicesToEnable { get; set; }

        [XmlElement("agentStateTrace")]
        public bool? AgentStateTrace { get; set; }

        [XmlElement("agentTeam")]
        public required ReferenceBean AgentTeam { get; set; }

        [XmlElement("attributeValue")]
        public string? AttributeValue { get; set; }

        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("canRemove")]
        public bool? CanRemove { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("configParam")]
        public string? ConfigParam { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("datacenter")]
        public required ReferenceBean Datacenter { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("markDeletable")]
        public bool? MarkDeletable { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("peripheral")]
        public required PeripheralRef Peripheral { get; set; }

        [XmlElement("peripheralName")]
        public string? PeripheralName { get; set; }

        [XmlElement("peripheralSet")]
        public required ReferenceBean PeripheralSet { get; set; }

        [XmlElement("person")]
        public required Person Person { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("selectedAttribute")]
        public bool? SelectedAttribute { get; set; }

        [XmlElement("selectedSkillGroup")]
        public bool? SelectedSkillGroup { get; set; }

        [XmlElement("supervisor")]
        public bool? Supervisor { get; set; }
    }
}