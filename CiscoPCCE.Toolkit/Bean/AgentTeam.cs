using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("/agentteam")
[XmlRoot("agentTeam")]
public class AgentTeam : BaseApiBean {
  private int? agentCount;
  private List<ReferenceBean>? agents;
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private ReferenceBean datacenter;
  private ReferenceBean department;
  private string? description;
  private ReferenceBean dialedNumber;
  private string? idFromRefUrl;
  private string? name;
  private PeripheralRef peripheral;
  private int? peripheralId;
  private ReferenceBean peripheralSet;
  private ReferenceBean primarySupervisor;
  private string? refURL;
  private int? supervisorCount;
  private List<ReferenceBean>? supervisors;

  public int? AgentCount
  {
      get => agentCount;
      set => agentCount = value;
  }


  public void setAgentCount(int? agentCount) {
     this.agentCount = agentCount;
  }

  [XmlElement("agents")]
  [XmlElement("agent")]
  public List<ReferenceBean>? Agents
  {
      get => agents;
      set => agents = value;
  }


  public void setAgents(List<ReferenceBean> agents) {
     this.agents = agents;
  }

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }


  public void setBaseUrlfromRefUrl(String baseUrlfromRefUrl) {
     this.baseUrlfromRefUrl = baseUrlfromRefUrl;
  }

  public int? ChangeStamp
  {
      get => changeStamp;
      set => changeStamp = value;
  }


  public void setChangeStamp(int? changeStamp) {
     this.changeStamp = changeStamp;
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

  public ReferenceBean DialedNumber
  {
      get => dialedNumber;
      set => dialedNumber = value;
  }


  public void setDialedNumber(ReferenceBean dialedNumber) {
     this.dialedNumber = dialedNumber;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }


  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
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

  public int? PeripheralId
  {
      get => peripheralId;
      set => peripheralId = value;
  }


  public void setPeripheralId(int? peripheralId) {
     this.peripheralId = peripheralId;
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

  public ReferenceBean PrimarySupervisor
  {
      get => primarySupervisor;
      set => primarySupervisor = value;
  }


  public void setPrimarySupervisor(ReferenceBean primarySupervisor) {
     this.primarySupervisor = primarySupervisor;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public int? SupervisorCount
  {
      get => supervisorCount;
      set => supervisorCount = value;
  }


  public void setSupervisorCount(int? supervisorCount) {
     this.supervisorCount = supervisorCount;
  }

  [XmlElement("supervisors")]
  [XmlElement("supervisor")]
  public List<ReferenceBean>? Supervisors
  {
      get => supervisors;
      set => supervisors = value;
  }


  public void setSupervisors(List<ReferenceBean> supervisors) {
     this.supervisors = supervisors;
  }


  // Path("/agentteam")
  [XmlRoot("results")]
  public class AgentTeamList : BaseApiListBean<AgentTeam> {
    [XmlElement("agentTeams")]
    [XmlElement("agentTeam")]
   
    public override List<AgentTeam>? GetItems() => items;

    public override void SetItems(List<AgentTeam>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<AgentTeam>? items)
    {
        this.items = items;
    }
  }
}

}