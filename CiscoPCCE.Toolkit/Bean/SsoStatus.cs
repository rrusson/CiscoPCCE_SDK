using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("sso")
[XmlRoot("ssoStatus")]
public class SsoStatus : BaseApiBean {
  private SsoGlobalEnabledState globalSsoState;
  private bool? hasIdsCredentials;
  private IdSConfigurationState idSConfigurationState;
  private string? idsBaseUrl;
  private SsoOperationState modeState;
  private SsoOperationState registrationState;
  private List<SsoComponentStatus>? ssoComponentStatuses;

  public SsoGlobalEnabledState GlobalSsoState
  {
      get => globalSsoState;
      set => globalSsoState = value;
  }


  public void setGlobalSsoState(SsoGlobalEnabledState globalSsoState) {
     this.globalSsoState = globalSsoState;
  }

  public bool? HasIdsCredentials
  {
      get => hasIdsCredentials;
      set => hasIdsCredentials = value;
  }


  public void setHasIdsCredentials(Boolean hasIdsCredentials) {
     this.hasIdsCredentials = hasIdsCredentials;
  }

  public IdSConfigurationState IdSConfigurationState
  {
      get => idSConfigurationState;
      set => idSConfigurationState = value;
  }


  public void setIdSConfigurationState(IdSConfigurationState idSConfigurationState) {
     this.idSConfigurationState = idSConfigurationState;
  }

  public string? IdsBaseUrl
  {
      get => idsBaseUrl;
      set => idsBaseUrl = value;
  }


  public void setIdsBaseUrl(String idsBaseUrl) {
     this.idsBaseUrl = idsBaseUrl;
  }

  public SsoOperationState ModeState
  {
      get => modeState;
      set => modeState = value;
  }


  public void setModeState(SsoOperationState modeState) {
     this.modeState = modeState;
  }

  public SsoOperationState RegistrationState
  {
      get => registrationState;
      set => registrationState = value;
  }


  public void setRegistrationState(SsoOperationState registrationState) {
     this.registrationState = registrationState;
  }

  [XmlElement("##default")]
  [XmlElement("ssoComponentStatus")]
  public List<SsoComponentStatus>? SsoComponentStatuses
  {
      get => ssoComponentStatuses;
      set => ssoComponentStatuses = value;
  }


  public void setSsoComponentStatuses(List<SsoComponentStatus> ssoComponentStatuses) {
     this.ssoComponentStatuses = ssoComponentStatuses;
  }


  // Path("sso")
  [XmlRoot("results")]
  public class SsoStatusList : BaseApiListBean<SsoStatus> {
    [XmlElement("ssoStatuss")]
    [XmlElement("ssoStatus")]
   
    public override List<SsoStatus>? GetItems() => items;

    public override void SetItems(List<SsoStatus>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<SsoStatus>? items)
    {
        this.items = items;
    }
  }
}

}