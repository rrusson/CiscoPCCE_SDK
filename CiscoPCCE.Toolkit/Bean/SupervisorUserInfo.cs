using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("agent")
[XmlRoot("supervisorUserInfo")]
public class SupervisorUserInfo : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private ReferenceBean department;
  private string? domainName;
  private string? idFromRefUrl;
  private bool? ssoEnabled;
  private bool? supervisor;
  private string? userName;

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

  public string? DomainName
  {
      get => domainName;
      set => domainName = value;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }

  public bool? SsoEnabled
  {
      get => ssoEnabled;
      set => ssoEnabled = value;
  }

  public bool? Supervisor
  {
      get => supervisor;
      set => supervisor = value;
  }

  public string? UserName
  {
      get => userName;
      set => userName = value;
  }

  // Path("agent")
  [XmlRoot("results")]
  public class SupervisorUserInfoList : BaseApiListBean<SupervisorUserInfo> {    public override List<SupervisorUserInfo>? GetItems() => items;

    public override void SetItems(List<SupervisorUserInfo>? value) => items = value;

  }
}

}