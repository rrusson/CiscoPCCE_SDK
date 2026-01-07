using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("sipservergroupproperties")
[XmlRoot("sipServerGroupProperties")]
public class SIPServerGroupProperties : BaseApiBean {
  private string? optionsOverrideHost;
  private int? serverGroupDownInterval;
  private int? serverGroupHBLocalListenPort;
  private string? serverGroupHBMethod;
  private int? serverGroupHBNumTries;
  private int? serverGroupHBTimeout;
  private string? serverGroupHBTransportType;
  private bool? serverGroupHeartbeats;
  private string? serverGroupOverloadedResponseCodes;
  private int? serverGroupUpInterval;

  public string? OptionsOverrideHost
  {
      get => optionsOverrideHost;
      set => optionsOverrideHost = value;
  }

  public int? ServerGroupDownInterval
  {
      get => serverGroupDownInterval;
      set => serverGroupDownInterval = value;
  }

  public int? ServerGroupHBLocalListenPort
  {
      get => serverGroupHBLocalListenPort;
      set => serverGroupHBLocalListenPort = value;
  }

  public string? ServerGroupHBMethod
  {
      get => serverGroupHBMethod;
      set => serverGroupHBMethod = value;
  }

  public int? ServerGroupHBNumTries
  {
      get => serverGroupHBNumTries;
      set => serverGroupHBNumTries = value;
  }

  public int? ServerGroupHBTimeout
  {
      get => serverGroupHBTimeout;
      set => serverGroupHBTimeout = value;
  }

  public string? ServerGroupHBTransportType
  {
      get => serverGroupHBTransportType;
      set => serverGroupHBTransportType = value;
  }

  public bool? ServerGroupHeartbeats
  {
      get => serverGroupHeartbeats;
      set => serverGroupHeartbeats = value;
  }

  public string? ServerGroupOverloadedResponseCodes
  {
      get => serverGroupOverloadedResponseCodes;
      set => serverGroupOverloadedResponseCodes = value;
  }

  public int? ServerGroupUpInterval
  {
      get => serverGroupUpInterval;
      set => serverGroupUpInterval = value;
  }

  // Path("sipservergroupproperties")
  [XmlRoot("results")]
  public class SIPServerGroupPropertiesList : BaseApiListBean<SIPServerGroupProperties> {    public override List<SIPServerGroupProperties>? GetItems() => items;

    public override void SetItems(List<SIPServerGroupProperties>? value) => items = value;

  }
}

}