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


  public void setApiErrors(List<ApiError> apiErrors) {
     this.apiErrors = apiErrors;
  }

  public SsoOperationState ModeState
  {
      get => modeState;
      set => modeState = value;
  }


  public void setModeState(SsoOperationState modeState) {
     this.modeState = modeState;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }


  public void setName(String name) {
     this.name = name;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public SsoOperationState RegistrationState
  {
      get => registrationState;
      set => registrationState = value;
  }


  public void setRegistrationState(SsoOperationState registrationState) {
     this.registrationState = registrationState;
  }

  public string? SsoTestPath
  {
      get => ssoTestPath;
      set => ssoTestPath = value;
  }


  public void setSsoTestPath(String ssoTestPath) {
     this.ssoTestPath = ssoTestPath;
  }


  // Path("sso")
  [XmlRoot("results")]
  public class SsoComponentStatusList : BaseApiListBean<SsoComponentStatus> {
    [XmlElement("ssoComponentStatuss")]
    [XmlElement("ssoComponentStatus")]
   
    public override List<SsoComponentStatus>? GetItems() => items;

    public override void SetItems(List<SsoComponentStatus>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<SsoComponentStatus>? items)
    {
        this.items = items;
    }
  }
}

}