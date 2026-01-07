using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class AgentDataCenterSetting : BaseApiBean {
  private int? agentPhoneLineControl;
  private string? baseUrl;
  private ReferenceBean defaultDeskSetting;
  private int? nonACDLineImpact;

  public int? AgentPhoneLineControl
  {
      get => agentPhoneLineControl;
      set => agentPhoneLineControl = value;
  }


  public void setAgentPhoneLineControl(int? agentPhoneLineControl) {
     this.agentPhoneLineControl = agentPhoneLineControl;
  }

  public string? BaseUrl
  {
      get => baseUrl;
      set => baseUrl = value;
  }


  public void setBaseUrl(String baseUrl) {
     this.baseUrl = baseUrl;
  }

  public ReferenceBean DefaultDeskSetting
  {
      get => defaultDeskSetting;
      set => defaultDeskSetting = value;
  }


  public void setDefaultDeskSetting(ReferenceBean defaultDeskSetting) {
     this.defaultDeskSetting = defaultDeskSetting;
  }

  public int? NonACDLineImpact
  {
      get => nonACDLineImpact;
      set => nonACDLineImpact = value;
  }


  public void setNonACDLineImpact(int? nonACDLineImpact) {
     this.nonACDLineImpact = nonACDLineImpact;
  }


}

}