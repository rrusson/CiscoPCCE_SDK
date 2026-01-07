using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("agent")
public class AgentBase : BaseApiBean {
                                                    
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

  public ReferenceBean AgentTeam { get; set; }

  public string? AttributeValue { get; set; }

  public string? BaseUrlfromRefUrl { get; set; }

  public bool? CanRemove { get; set; }

  public int? ChangeStamp { get; set; }

  public string? ConfigParam { get; set; }

  public string? CorrelationId { get; set; }

  public ReferenceBean Datacenter { get; set; }

  public ReferenceBean Department { get; set; }

  public string? Description { get; set; }

  public string? IdFromRefUrl { get; set; }

  public bool? MarkDeletable { get; set; }

  public string? Name { get; set; }

  public PeripheralRef Peripheral { get; set; }

  public string? PeripheralName { get; set; }

  [XmlElement("peripheralSet")]
  public ReferenceBean PeripheralSet { get; set; }

  public Person Person { get; set; }

  public string? RefURL { get; set; }

  public bool? SelectedAttribute { get; set; }

  public bool? SelectedSkillGroup { get; set; }

  public bool? Supervisor { get; set; }

}

}