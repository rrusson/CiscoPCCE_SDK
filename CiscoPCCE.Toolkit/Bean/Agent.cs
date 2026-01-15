using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("agent")]
    public class Agent : BaseApiBean
    {
        [XmlElement("agentDeskSettings")]
        public required ReferenceBean AgentDeskSettings { get; set; }

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

        [XmlArray("agentAttributes")]
        [XmlArrayItem("agentAttribute")]
        public List<AttributeValueWithAttribute>? Attributes { get; set; }

        [XmlArray("agentAttributesAdded")]
        [XmlArrayItem("agentAttribute")]
        public List<AttributeValueWithAttribute>? AttributesAdded { get; set; }

        [XmlArray("agentAttributesRemoved")]
        [XmlArrayItem("agentAttribute")]
        public List<AttributeValueWithAttribute>? AttributesRemoved { get; set; }

        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("canRemove")]
        public bool? CanRemove { get; set; }

        [XmlElement("configParam")]
        public string? ConfigParam { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("datacenter")]
        public required ReferenceBean Datacenter { get; set; }

        [XmlElement("defaultSkillGroup")]
        public required ReferenceBean DefaultSkillGroup { get; set; }

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

        [XmlElement("selectedAttribute")]
        public bool? SelectedAttribute { get; set; }

        [XmlElement("selectedSkillGroup")]
        public bool? SelectedSkillGroup { get; set; }

        [XmlArray("skillGroups")]
        [XmlArrayItem("skillGroup")]
        public List<ReferenceBean>? SkillGroups { get; set; }

        [XmlArray("skillGroupsAdded")]
        [XmlArrayItem("skillGroup")]
        public List<ReferenceBean>? SkillGroupsAdded { get; set; }

        [XmlArray("skillGroupsRemoved")]
        [XmlArrayItem("skillGroup")]
        public List<ReferenceBean>? SkillGroupsRemoved { get; set; }

        [XmlElement("supervisor")]
        public bool? Supervisor { get; set; }

        [XmlArray("supervisorTeams")]
        [XmlArrayItem("supervisorTeam")]
        public List<ReferenceBean>? SupervisorTeams { get; set; }
    }
}