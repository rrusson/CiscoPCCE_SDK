using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("/agentteam")
[XmlRoot("agentTeamSummary")]
public class AgentTeamSummary : BaseApiBean {
  private int? agentCount;
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
  private string? refURL;
  private int? supervisorCount;

  public int? AgentCount
  {
      get => agentCount;
      set => agentCount = value;
  }

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }

  public int? ChangeStamp
  {
      get => changeStamp;
      set => changeStamp = value;
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

  public ReferenceBean DialedNumber
  {
      get => dialedNumber;
      set => dialedNumber = value;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
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

  public int? PeripheralId
  {
      get => peripheralId;
      set => peripheralId = value;
  }

  [XmlElement("peripheralSet")]
  public ReferenceBean PeripheralSet
  {
      get => peripheralSet;
      set => peripheralSet = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  public int? SupervisorCount
  {
      get => supervisorCount;
      set => supervisorCount = value;
  }

  // Path("/agentteam")
  [XmlRoot("results")]
  public class AgentTeamSummaryList : BaseApiListBean<AgentTeamSummary> {    public override List<AgentTeamSummary>? GetItems() => items;

    public override void SetItems(List<AgentTeamSummary>? value) => items = value;

  }
}

}