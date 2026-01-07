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

  public bool? HasIdsCredentials
  {
      get => hasIdsCredentials;
      set => hasIdsCredentials = value;
  }

  public IdSConfigurationState IdSConfigurationState
  {
      get => idSConfigurationState;
      set => idSConfigurationState = value;
  }

  public string? IdsBaseUrl
  {
      get => idsBaseUrl;
      set => idsBaseUrl = value;
  }

  public SsoOperationState ModeState
  {
      get => modeState;
      set => modeState = value;
  }

  public SsoOperationState RegistrationState
  {
      get => registrationState;
      set => registrationState = value;
  }

  [XmlElement("##default")]
  [XmlElement("ssoComponentStatus")]
  public List<SsoComponentStatus>? SsoComponentStatuses
  {
      get => ssoComponentStatuses;
      set => ssoComponentStatuses = value;
  }

  // Path("sso")
  [XmlRoot("results")]
  public class SsoStatusList : BaseApiListBean<SsoStatus> {    public override List<SsoStatus>? GetItems() => items;

    public override void SetItems(List<SsoStatus>? value) => items = value;

  }
}

}