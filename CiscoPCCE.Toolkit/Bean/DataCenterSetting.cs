using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class DataCenterSetting : BaseApiBean {
  private AgentDataCenterSetting agent;
  private string? baseUrl;
  private ReferenceBean datacenter;
  private NetworkLabelGlobalSetting labels;

  public AgentDataCenterSetting Agent
  {
      get => agent;
      set => agent = value;
  }


  public void setAgent(AgentDataCenterSetting agent) {
     this.agent = agent;
  }

  public string? BaseUrl
  {
      get => baseUrl;
      set => baseUrl = value;
  }


  public void setBaseUrl(String baseUrl) {
     this.baseUrl = baseUrl;
  }

  public ReferenceBean Datacenter
  {
      get => datacenter;
      set => datacenter = value;
  }


  public void setDatacenter(ReferenceBean datacenter) {
     this.datacenter = datacenter;
  }

  public NetworkLabelGlobalSetting Labels
  {
      get => labels;
      set => labels = value;
  }


  public void setLabels(NetworkLabelGlobalSetting labels) {
     this.labels = labels;
  }


}

}