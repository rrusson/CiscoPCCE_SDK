using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("sso")
[XmlRoot("ssoComponentStatus")]
public class SsoComponentStatus : BaseApiBean {
  private List<ApiError>? apiErrors;
  private SsoOperationState modeState;
  private string? name;
  private string? refURL;
  private SsoOperationState registrationState;
  private string? ssoTestPath;

  [XmlElement("##default")]
  [XmlElement("apiError")]
  public List<ApiError>? ApiErrors
  {
      get => apiErrors;
      set => apiErrors = value;
  }

  public SsoOperationState ModeState
  {
      get => modeState;
      set => modeState = value;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  public SsoOperationState RegistrationState
  {
      get => registrationState;
      set => registrationState = value;
  }

  public string? SsoTestPath
  {
      get => ssoTestPath;
      set => ssoTestPath = value;
  }

  // Path("sso")
  [XmlRoot("results")]
  public class SsoComponentStatusList : BaseApiListBean<SsoComponentStatus> {    public override List<SsoComponentStatus>? GetItems() => items;

    public override void SetItems(List<SsoComponentStatus>? value) => items = value;

  }
}

}