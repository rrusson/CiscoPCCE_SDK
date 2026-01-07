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


  public void setAgentHistoricalData(Boolean agentHistoricalData) {
     this.agentHistoricalData = agentHistoricalData;
  }

  public bool? AgentRealTimeData
  {
      get => agentRealTimeData;
      set => agentRealTimeData = value;
  }


  public void setAgentRealTimeData(Boolean agentRealTimeData) {
     this.agentRealTimeData = agentRealTimeData;
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

  public ReferenceBean Department
  {
      get => department;
      set => department = value;
  }


  public void setDepartment(ReferenceBean department) {
     this.department = department;
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

  public int? PeripheralId
  {
      get => peripheralId;
      set => peripheralId = value;
  }


  public void setPeripheralId(int? peripheralId) {
     this.peripheralId = peripheralId;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }


  // Path("agentdistribution")
  [XmlRoot("results")]
  public class AgentDistributionList : BaseApiListBean<AgentDistribution> {
    [XmlElement("agentDistributions")]
    [XmlElement("agentDistribution")]
   
    public override List<AgentDistribution>? GetItems() => items;

    public override void SetItems(List<AgentDistribution>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<AgentDistribution>? items)
    {
        this.items = items;
    }
  }
}

}