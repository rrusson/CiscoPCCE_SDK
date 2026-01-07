using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("sso")
[XmlRoot("ssoState")]
public class SsoGlobalState : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private ReferenceBean department;
  private string? idFromRefUrl;
  private PermissionInfo permissionInfo;
  private string? refURL;
  private SsoGlobalEnabledState state;

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

  public PermissionInfo PermissionInfo
  {
      get => permissionInfo;
      set => permissionInfo = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  public SsoGlobalEnabledState State
  {
      get => state;
      set => state = value;
  }

  // Path("sso")
  [XmlRoot("results")]
  public class SsoGlobalStateList : BaseApiListBean<SsoGlobalState> {    public override List<SsoGlobalState>? GetItems() => items;

    public override void SetItems(List<SsoGlobalState>? value) => items = value;

  }
}

}