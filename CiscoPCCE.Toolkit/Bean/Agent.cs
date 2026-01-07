using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("agent")
[XmlRoot("agent")]
public class Agent : BaseApiBean {
  private ReferenceBean agentDeskSettings;
  private string? agentId;
  private List<AgentServiceEnabled>? agentServicesEnabled;
  private List<AgentServiceEnabled>? agentServicesToDisable;
  private List<AgentServiceEnabled>? agentServicesToEnable;
  private bool? agentStateTrace;
  private ReferenceBean agentTeam;
  private string? attributeValue;
  private List<AttributeValueWithAttribute>? attributes;
  private List<AttributeValueWithAttribute>? attributesAdded;
  private List<AttributeValueWithAttribute>? attributesRemoved;
  private string? baseUrlfromRefUrl;
  private bool? canRemove;
  private int? changeStamp;
  private string? configParam;
  private string? correlationId;
  private ReferenceBean datacenter;
  private ReferenceBean defaultSkillGroup;
  private ReferenceBean department;
  private string? description;
  private string? idFromRefUrl;
  private bool? markDeletable;
  private string? name;
  private PeripheralRef peripheral;
  private string? peripheralName;
  private ReferenceBean peripheralSet;
  private Person person;
  private string? refURL;
  private bool? selectedAttribute;
  private bool? selectedSkillGroup;
  private List<ReferenceBean>? skillGroups;
  private List<ReferenceBean>? skillGroupsAdded;
  private List<ReferenceBean>? skillGroupsRemoved;
  private bool? supervisor;
  private List<ReferenceBean>? supervisorTeams;

  public ReferenceBean AgentDeskSettings
  {
      get => agentDeskSettings;
      set => agentDeskSettings = value;
  }

  public string? AgentId
  {
      get => agentId;
      set => agentId = value;
  }

  [XmlElement("agentServicesEnabled")]
  [XmlElement("agentService")]
  public List<AgentServiceEnabled>? AgentServicesEnabled
  {
      get => agentServicesEnabled;
      set => agentServicesEnabled = value;
  }

  [XmlElement("agentServicesToDisable")]
  [XmlElement("agentService")]
  public List<AgentServiceEnabled>? AgentServicesToDisable
  {
      get => agentServicesToDisable;
      set => agentServicesToDisable = value;
  }

  [XmlElement("agentServicesToEnable")]
  [XmlElement("agentService")]
  public List<AgentServiceEnabled>? AgentServicesToEnable
  {
      get => agentServicesToEnable;
      set => agentServicesToEnable = value;
  }

  public bool? AgentStateTrace
  {
      get => agentStateTrace;
      set => agentStateTrace = value;
  }

  public ReferenceBean AgentTeam
  {
      get => agentTeam;
      set => agentTeam = value;
  }

  public string? AttributeValue
  {
      get => attributeValue;
      set => attributeValue = value;
  }

  [XmlElement("agentAttributes")]
  [XmlElement("agentAttribute")]
  public List<AttributeValueWithAttribute>? Attributes
  {
      get => attributes;
      set => attributes = value;
  }

  [XmlElement("agentAttributesAdded")]
  [XmlElement("agentAttribute")]
  public List<AttributeValueWithAttribute>? AttributesAdded
  {
      get => attributesAdded;
      set => attributesAdded = value;
  }

  [XmlElement("agentAttributesRemoved")]
  [XmlElement("agentAttribute")]
  public List<AttributeValueWithAttribute>? AttributesRemoved
  {
      get => attributesRemoved;
      set => attributesRemoved = value;
  }

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }

  public bool? CanRemove
  {
      get => canRemove;
      set => canRemove = value;
  }

  public int? ChangeStamp
  {
      get => changeStamp;
      set => changeStamp = value;
  }

  public string? ConfigParam
  {
      get => configParam;
      set => configParam = value;
  }

  public string? CorrelationId
  {
      get => correlationId;
      set => correlationId = value;
  }

  public ReferenceBean Datacenter
  {
      get => datacenter;
      set => datacenter = value;
  }

  public ReferenceBean DefaultSkillGroup
  {
      get => defaultSkillGroup;
      set => defaultSkillGroup = value;
  }

  public ReferenceBean Department
  {
      get => department;
      set => department = value;
  }

  public string? Description
  {
      get => description;
      set => description = value;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }

  public bool? MarkDeletable
  {
      get => markDeletable;
      set => markDeletable = value;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }

  public PeripheralRef Peripheral
  {
      get => peripheral;
      set => peripheral = value;
  }

  public string? PeripheralName
  {
      get => peripheralName;
      set => peripheralName = value;
  }

  [XmlElement("peripheralSet")]
  public ReferenceBean PeripheralSet
  {
      get => peripheralSet;
      set => peripheralSet = value;
  }

  public Person Person
  {
      get => person;
      set => person = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  public bool? SelectedAttribute
  {
      get => selectedAttribute;
      set => selectedAttribute = value;
  }

  public bool? SelectedSkillGroup
  {
      get => selectedSkillGroup;
      set => selectedSkillGroup = value;
  }

  [XmlElement("skillGroups")]
  [XmlElement("skillGroup")]
  public List<ReferenceBean>? SkillGroups
  {
      get => skillGroups;
      set => skillGroups = value;
  }

  [XmlElement("skillGroupsAdded")]
  [XmlElement("skillGroup")]
  public List<ReferenceBean>? SkillGroupsAdded
  {
      get => skillGroupsAdded;
      set => skillGroupsAdded = value;
  }

  [XmlElement("skillGroupsRemoved")]
  [XmlElement("skillGroup")]
  public List<ReferenceBean>? SkillGroupsRemoved
  {
      get => skillGroupsRemoved;
      set => skillGroupsRemoved = value;
  }

  public bool? Supervisor
  {
      get => supervisor;
      set => supervisor = value;
  }

  [XmlElement("supervisorTeams")]
  [XmlElement("supervisorTeam")]
  public List<ReferenceBean>? SupervisorTeams
  {
      get => supervisorTeams;
      set => supervisorTeams = value;
  }

  // Path("agent")
  [XmlRoot("results")]
  public class AgentList : BaseApiListBean<Agent> {    public override List<Agent>? GetItems() => items;

    public override void SetItems(List<Agent>? value) => items = value;

  }
}

}