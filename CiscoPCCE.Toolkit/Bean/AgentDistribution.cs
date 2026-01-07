using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("agentdistribution")
[XmlRoot("agentDistribution")]
public class AgentDistribution : BaseApiBean {
  private bool? agentHistoricalData;
  private bool? agentRealTimeData;
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private ReferenceBean department;
  private string? idFromRefUrl;
  private string? name;
  private int? peripheralId;
  private string? refURL;

  public bool? AgentHistoricalData
  {
      get => agentHistoricalData;
      set => agentHistoricalData = value;
  }

  public bool? AgentRealTimeData
  {
      get => agentRealTimeData;
      set => agentRealTimeData = value;
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

  public ReferenceBean Department
  {
      get => department;
      set => department = value;
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

  public int? PeripheralId
  {
      get => peripheralId;
      set => peripheralId = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  // Path("agentdistribution")
  [XmlRoot("results")]
  public class AgentDistributionList : BaseApiListBean<AgentDistribution> {    public override List<AgentDistribution>? GetItems() => items;

    public override void SetItems(List<AgentDistribution>? value) => items = value;

  }
}

}