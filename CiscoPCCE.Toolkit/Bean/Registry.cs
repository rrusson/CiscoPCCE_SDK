using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("registry")
[XmlRoot("registry")]
public class Registry : BaseApiBean {
  private int? appGwEnabled;
  private string? cgListenPort;
  private int? conapiEnabled;
  private int? hdsType;
  private bool? instanceCreated;
  private string? instanceName;
  private string? jtapiCUCMSubAddress;
  private string? jtapiClientVersion;
  private string? jtapiUser;
  private string? locale;
  private List<PeripheralWithRoutingClient>? mediaRoutingPeripherals;
  private string? mrPG;
  private int? outboundEnabled;
  private List<PeripheralGatewaysRegistry>? peripheralGatewaysRegistries;
  private string? ucmPG;
  private string? ucmPGTIPPort;
  private string? ucmPGTOSPort;
  private string? vruPG;

  public int? AppGwEnabled
  {
      get => appGwEnabled;
      set => appGwEnabled = value;
  }


  public void setAppGwEnabled(int? appGwEnabled) {
     this.appGwEnabled = appGwEnabled;
  }

  public string? CgListenPort
  {
      get => cgListenPort;
      set => cgListenPort = value;
  }


  public void setCgListenPort(String cgListenPort) {
     this.cgListenPort = cgListenPort;
  }

  public int? ConapiEnabled
  {
      get => conapiEnabled;
      set => conapiEnabled = value;
  }


  public void setConapiEnabled(int? conapiEnabled) {
     this.conapiEnabled = conapiEnabled;
  }

  public int? HdsType
  {
      get => hdsType;
      set => hdsType = value;
  }


  public void setHdsType(int? hdsType) {
     this.hdsType = hdsType;
  }

  public bool? InstanceCreated
  {
      get => instanceCreated;
      set => instanceCreated = value;
  }


  public void setInstanceCreated(Boolean instanceCreated) {
     this.instanceCreated = instanceCreated;
  }

  public string? InstanceName
  {
      get => instanceName;
      set => instanceName = value;
  }


  public void setInstanceName(String instanceName) {
     this.instanceName = instanceName;
  }

  public string? JtapiCUCMSubAddress
  {
      get => jtapiCUCMSubAddress;
      set => jtapiCUCMSubAddress = value;
  }


  public void setJtapiCUCMSubAddress(String jtapiCUCMSubAddress) {
     this.jtapiCUCMSubAddress = jtapiCUCMSubAddress;
  }

  public string? JtapiClientVersion
  {
      get => jtapiClientVersion;
      set => jtapiClientVersion = value;
  }


  public void setJtapiClientVersion(String jtapiClientVersion) {
     this.jtapiClientVersion = jtapiClientVersion;
  }

  public string? JtapiUser
  {
      get => jtapiUser;
      set => jtapiUser = value;
  }


  public void setJtapiUser(String jtapiUser) {
     this.jtapiUser = jtapiUser;
  }

  public string? Locale
  {
      get => locale;
      set => locale = value;
  }


  public void setLocale(String locale) {
     this.locale = locale;
  }

  [XmlElement("mediaRoutingPeripherals")]
  [XmlElement("mediaRoutingPeripheral")]
  public List<PeripheralWithRoutingClient>? MediaRoutingPeripherals
  {
      get => mediaRoutingPeripherals;
      set => mediaRoutingPeripherals = value;
  }


  public void setMediaRoutingPeripherals(List<PeripheralWithRoutingClient> mediaRoutingPeripherals) {
     this.mediaRoutingPeripherals = mediaRoutingPeripherals;
  }

  public string? MrPG
  {
      get => mrPG;
      set => mrPG = value;
  }


  public void setMrPG(String mrPG) {
     this.mrPG = mrPG;
  }

  public int? OutboundEnabled
  {
      get => outboundEnabled;
      set => outboundEnabled = value;
  }


  public void setOutboundEnabled(int? outboundEnabled) {
     this.outboundEnabled = outboundEnabled;
  }

  [XmlElement("peripheralGatewaysRegistries")]
  [XmlElement("peripheralGatewaysRegistry")]
  public List<PeripheralGatewaysRegistry>? PeripheralGatewaysRegistries
  {
      get => peripheralGatewaysRegistries;
      set => peripheralGatewaysRegistries = value;
  }


  public void setPeripheralGatewaysRegistries(List<PeripheralGatewaysRegistry> peripheralGatewaysRegistries) {
     this.peripheralGatewaysRegistries = peripheralGatewaysRegistries;
  }

  public string? UcmPG
  {
      get => ucmPG;
      set => ucmPG = value;
  }


  public void setUcmPG(String ucmPG) {
     this.ucmPG = ucmPG;
  }

  public string? UcmPGTIPPort
  {
      get => ucmPGTIPPort;
      set => ucmPGTIPPort = value;
  }


  public void setUcmPGTIPPort(String ucmPGTIPPort) {
     this.ucmPGTIPPort = ucmPGTIPPort;
  }

  public string? UcmPGTOSPort
  {
      get => ucmPGTOSPort;
      set => ucmPGTOSPort = value;
  }


  public void setUcmPGTOSPort(String ucmPGTOSPort) {
     this.ucmPGTOSPort = ucmPGTOSPort;
  }

  public string? VruPG
  {
      get => vruPG;
      set => vruPG = value;
  }


  public void setVruPG(String vruPG) {
     this.vruPG = vruPG;
  }


  // Path("registry")
  [XmlRoot("results")]
  public class RegistryList : BaseApiListBean<Registry> {
    [XmlElement("registrys")]
    [XmlElement("registry")]
   
    public override List<Registry>? GetItems() => items;

    public override void SetItems(List<Registry>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<Registry>? items)
    {
        this.items = items;
    }
  }
}

}