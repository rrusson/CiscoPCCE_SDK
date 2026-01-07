using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("generalsetting")
[XmlRoot("generalSettings")]
public class GeneralSetting : BaseApiBean {
  private bool? agentEventDetailExtended;
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private ReferenceBean department;
  private string? idFromRefUrl;
  private LoginSession loginSession;
  private string? refURL;

  public bool? AgentEventDetailExtended
  {
      get => agentEventDetailExtended;
      set => agentEventDetailExtended = value;
  }


  public void setAgentEventDetailExtended(Boolean agentEventDetailExtended) {
     this.agentEventDetailExtended = agentEventDetailExtended;
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

  public LoginSession LoginSession
  {
      get => loginSession;
      set => loginSession = value;
  }


  public void setLoginSession(LoginSession loginSession) {
     this.loginSession = loginSession;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }


  // Path("generalsetting")
  [XmlRoot("results")]
  public class GeneralSettingList : BaseApiListBean<GeneralSetting> {
    [XmlElement("generalSettingss")]
    [XmlElement("generalSettings")]
   
    public override List<GeneralSetting>? GetItems() => items;

    public override void SetItems(List<GeneralSetting>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<GeneralSetting>? items)
    {
        this.items = items;
    }
  }
}

}