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


  public void setOptionsOverrideHost(String optionsOverrideHost) {
     this.optionsOverrideHost = optionsOverrideHost;
  }

  public int? ServerGroupDownInterval
  {
      get => serverGroupDownInterval;
      set => serverGroupDownInterval = value;
  }


  public void setServerGroupDownInterval(int? serverGroupDownInterval) {
     this.serverGroupDownInterval = serverGroupDownInterval;
  }

  public int? ServerGroupHBLocalListenPort
  {
      get => serverGroupHBLocalListenPort;
      set => serverGroupHBLocalListenPort = value;
  }


  public void setServerGroupHBLocalListenPort(int? serverGroupHBLocalListenPort) {
     this.serverGroupHBLocalListenPort = serverGroupHBLocalListenPort;
  }

  public string? ServerGroupHBMethod
  {
      get => serverGroupHBMethod;
      set => serverGroupHBMethod = value;
  }


  public void setServerGroupHBMethod(String serverGroupHBMethod) {
     this.serverGroupHBMethod = serverGroupHBMethod;
  }

  public int? ServerGroupHBNumTries
  {
      get => serverGroupHBNumTries;
      set => serverGroupHBNumTries = value;
  }


  public void setServerGroupHBNumTries(int? serverGroupHBNumTries) {
     this.serverGroupHBNumTries = serverGroupHBNumTries;
  }

  public int? ServerGroupHBTimeout
  {
      get => serverGroupHBTimeout;
      set => serverGroupHBTimeout = value;
  }


  public void setServerGroupHBTimeout(int? serverGroupHBTimeout) {
     this.serverGroupHBTimeout = serverGroupHBTimeout;
  }

  public string? ServerGroupHBTransportType
  {
      get => serverGroupHBTransportType;
      set => serverGroupHBTransportType = value;
  }


  public void setServerGroupHBTransportType(String serverGroupHBTransportType) {
     this.serverGroupHBTransportType = serverGroupHBTransportType;
  }

  public bool? ServerGroupHeartbeats
  {
      get => serverGroupHeartbeats;
      set => serverGroupHeartbeats = value;
  }


  public void setServerGroupHeartbeats(Boolean serverGroupHeartbeats) {
     this.serverGroupHeartbeats = serverGroupHeartbeats;
  }

  public string? ServerGroupOverloadedResponseCodes
  {
      get => serverGroupOverloadedResponseCodes;
      set => serverGroupOverloadedResponseCodes = value;
  }


  public void setServerGroupOverloadedResponseCodes(String serverGroupOverloadedResponseCodes) {
     this.serverGroupOverloadedResponseCodes = serverGroupOverloadedResponseCodes;
  }

  public int? ServerGroupUpInterval
  {
      get => serverGroupUpInterval;
      set => serverGroupUpInterval = value;
  }


  public void setServerGroupUpInterval(int? serverGroupUpInterval) {
     this.serverGroupUpInterval = serverGroupUpInterval;
  }


  // Path("sipservergroupproperties")
  [XmlRoot("results")]
  public class SIPServerGroupPropertiesList : BaseApiListBean<SIPServerGroupProperties> {
    [XmlElement("sipServerGroupPropertiess")]
    [XmlElement("sipServerGroupProperties")]
   
    public override List<SIPServerGroupProperties>? GetItems() => items;

    public override void SetItems(List<SIPServerGroupProperties>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<SIPServerGroupProperties>? items)
    {
        this.items = items;
    }
  }
}

}