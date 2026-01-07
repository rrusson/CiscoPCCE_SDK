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

  public LoginSession LoginSession
  {
      get => loginSession;
      set => loginSession = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  // Path("generalsetting")
  [XmlRoot("results")]
  public class GeneralSettingList : BaseApiListBean<GeneralSetting> {    public override List<GeneralSetting>? GetItems() => items;

    public override void SetItems(List<GeneralSetting>? value) => items = value;

  }
}

}