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


  public void setAgentDeskSettings(ReferenceBean agentDeskSettings) {
     this.agentDeskSettings = agentDeskSettings;
  }

  public string? AgentId
  {
      get => agentId;
      set => agentId = value;
  }


  public void setAgentId(String agentId) {
     this.agentId = agentId;
  }

  [XmlElement("agentServicesEnabled")]
  [XmlElement("agentService")]
  public List<AgentServiceEnabled>? AgentServicesEnabled
  {
      get => agentServicesEnabled;
      set => agentServicesEnabled = value;
  }


  public void setAgentServicesEnabled(List<AgentServiceEnabled> agentServicesEnabled) {
     this.agentServicesEnabled = agentServicesEnabled;
  }

  [XmlElement("agentServicesToDisable")]
  [XmlElement("agentService")]
  public List<AgentServiceEnabled>? AgentServicesToDisable
  {
      get => agentServicesToDisable;
      set => agentServicesToDisable = value;
  }


  public void setAgentServicesToDisable(List<AgentServiceEnabled> agentServicesToDisable) {
     this.agentServicesToDisable = agentServicesToDisable;
  }

  [XmlElement("agentServicesToEnable")]
  [XmlElement("agentService")]
  public List<AgentServiceEnabled>? AgentServicesToEnable
  {
      get => agentServicesToEnable;
      set => agentServicesToEnable = value;
  }


  public void setAgentServicesToEnable(List<AgentServiceEnabled> agentServicesToEnable) {
     this.agentServicesToEnable = agentServicesToEnable;
  }

  public bool? AgentStateTrace
  {
      get => agentStateTrace;
      set => agentStateTrace = value;
  }


  public void setAgentStateTrace(Boolean agentStateTrace) {
     this.agentStateTrace = agentStateTrace;
  }

  public ReferenceBean AgentTeam
  {
      get => agentTeam;
      set => agentTeam = value;
  }


  public void setAgentTeam(ReferenceBean agentTeam) {
     this.agentTeam = agentTeam;
  }

  public string? AttributeValue
  {
      get => attributeValue;
      set => attributeValue = value;
  }


  public void setAttributeValue(String attributeValue) {
     this.attributeValue = attributeValue;
  }

  [XmlElement("agentAttributes")]
  [XmlElement("agentAttribute")]
  public List<AttributeValueWithAttribute>? Attributes
  {
      get => attributes;
      set => attributes = value;
  }


  public void setAttributes(List<AttributeValueWithAttribute> attributes) {
     this.attributes = attributes;
  }

  [XmlElement("agentAttributesAdded")]
  [XmlElement("agentAttribute")]
  public List<AttributeValueWithAttribute>? AttributesAdded
  {
      get => attributesAdded;
      set => attributesAdded = value;
  }


  public void setAttributesAdded(List<AttributeValueWithAttribute> attributesAdded) {
     this.attributesAdded = attributesAdded;
  }

  [XmlElement("agentAttributesRemoved")]
  [XmlElement("agentAttribute")]
  public List<AttributeValueWithAttribute>? AttributesRemoved
  {
      get => attributesRemoved;
      set => attributesRemoved = value;
  }


  public void setAttributesRemoved(List<AttributeValueWithAttribute> attributesRemoved) {
     this.attributesRemoved = attributesRemoved;
  }

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }


  public void setBaseUrlfromRefUrl(String baseUrlfromRefUrl) {
     this.baseUrlfromRefUrl = baseUrlfromRefUrl;
  }

  public bool? CanRemove
  {
      get => canRemove;
      set => canRemove = value;
  }


  public void setCanRemove(Boolean canRemove) {
     this.canRemove = canRemove;
  }

  public int? ChangeStamp
  {
      get => changeStamp;
      set => changeStamp = value;
  }


  public void setChangeStamp(int? changeStamp) {
     this.changeStamp = changeStamp;
  }

  public string? ConfigParam
  {
      get => configParam;
      set => configParam = value;
  }


  public void setConfigParam(String configParam) {
     this.configParam = configParam;
  }

  public string? CorrelationId
  {
      get => correlationId;
      set => correlationId = value;
  }


  public void setCorrelationId(String correlationId) {
     this.correlationId = correlationId;
  }

  public ReferenceBean Datacenter
  {
      get => datacenter;
      set => datacenter = value;
  }


  public void setDatacenter(ReferenceBean datacenter) {
     this.datacenter = datacenter;
  }

  public ReferenceBean DefaultSkillGroup
  {
      get => defaultSkillGroup;
      set => defaultSkillGroup = value;
  }


  public void setDefaultSkillGroup(ReferenceBean defaultSkillGroup) {
     this.defaultSkillGroup = defaultSkillGroup;
  }

  public ReferenceBean Department
  {
      get => department;
      set => department = value;
  }


  public void setDepartment(ReferenceBean department) {
     this.department = department;
  }

  public string? Description
  {
      get => description;
      set => description = value;
  }


  public void setDescription(String description) {
     this.description = description;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }


  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public bool? MarkDeletable
  {
      get => markDeletable;
      set => markDeletable = value;
  }


  public void setMarkDeletable(Boolean markDeletable) {
     this.markDeletable = markDeletable;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }


  public void setName(String name) {
     this.name = name;
  }

  public PeripheralRef Peripheral
  {
      get => peripheral;
      set => peripheral = value;
  }


  public void setPeripheral(PeripheralRef peripheral) {
     this.peripheral = peripheral;
  }

  public string? PeripheralName
  {
      get => peripheralName;
      set => peripheralName = value;
  }


  public void setPeripheralName(String peripheralName) {
     this.peripheralName = peripheralName;
  }

  [XmlElement("peripheralSet")]
  public ReferenceBean PeripheralSet
  {
      get => peripheralSet;
      set => peripheralSet = value;
  }


  public void setPeripheralSet(ReferenceBean peripheralSet) {
     this.peripheralSet = peripheralSet;
  }

  public Person Person
  {
      get => person;
      set => person = value;
  }


  public void setPerson(Person person) {
     this.person = person;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public bool? SelectedAttribute
  {
      get => selectedAttribute;
      set => selectedAttribute = value;
  }


  public void setSelectedAttribute(Boolean selectedAttribute) {
     this.selectedAttribute = selectedAttribute;
  }

  public bool? SelectedSkillGroup
  {
      get => selectedSkillGroup;
      set => selectedSkillGroup = value;
  }


  public void setSelectedSkillGroup(Boolean selectedSkillGroup) {
     this.selectedSkillGroup = selectedSkillGroup;
  }

  [XmlElement("skillGroups")]
  [XmlElement("skillGroup")]
  public List<ReferenceBean>? SkillGroups
  {
      get => skillGroups;
      set => skillGroups = value;
  }


  public void setSkillGroups(List<ReferenceBean> skillGroups) {
     this.skillGroups = skillGroups;
  }

  [XmlElement("skillGroupsAdded")]
  [XmlElement("skillGroup")]
  public List<ReferenceBean>? SkillGroupsAdded
  {
      get => skillGroupsAdded;
      set => skillGroupsAdded = value;
  }


  public void setSkillGroupsAdded(List<ReferenceBean> skillGroupsAdded) {
     this.skillGroupsAdded = skillGroupsAdded;
  }

  [XmlElement("skillGroupsRemoved")]
  [XmlElement("skillGroup")]
  public List<ReferenceBean>? SkillGroupsRemoved
  {
      get => skillGroupsRemoved;
      set => skillGroupsRemoved = value;
  }


  public void setSkillGroupsRemoved(List<ReferenceBean> skillGroupsRemoved) {
     this.skillGroupsRemoved = skillGroupsRemoved;
  }

  public bool? Supervisor
  {
      get => supervisor;
      set => supervisor = value;
  }


  public void setSupervisor(Boolean supervisor) {
     this.supervisor = supervisor;
  }

  [XmlElement("supervisorTeams")]
  [XmlElement("supervisorTeam")]
  public List<ReferenceBean>? SupervisorTeams
  {
      get => supervisorTeams;
      set => supervisorTeams = value;
  }


  public void setSupervisorTeams(List<ReferenceBean> supervisorTeams) {
     this.supervisorTeams = supervisorTeams;
  }


  // Path("agent")
  [XmlRoot("results")]
  public class AgentList : BaseApiListBean<Agent> {
    [XmlElement("agents")]
    [XmlElement("agent")]
   
    public override List<Agent>? GetItems() => items;

    public override void SetItems(List<Agent>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<Agent>? items)
    {
        this.items = items;
    }
  }
}

}