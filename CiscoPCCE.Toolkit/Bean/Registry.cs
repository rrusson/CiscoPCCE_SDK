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

  public string? CgListenPort
  {
      get => cgListenPort;
      set => cgListenPort = value;
  }

  public int? ConapiEnabled
  {
      get => conapiEnabled;
      set => conapiEnabled = value;
  }

  public int? HdsType
  {
      get => hdsType;
      set => hdsType = value;
  }

  public bool? InstanceCreated
  {
      get => instanceCreated;
      set => instanceCreated = value;
  }

  public string? InstanceName
  {
      get => instanceName;
      set => instanceName = value;
  }

  public string? JtapiCUCMSubAddress
  {
      get => jtapiCUCMSubAddress;
      set => jtapiCUCMSubAddress = value;
  }

  public string? JtapiClientVersion
  {
      get => jtapiClientVersion;
      set => jtapiClientVersion = value;
  }

  public string? JtapiUser
  {
      get => jtapiUser;
      set => jtapiUser = value;
  }

  public string? Locale
  {
      get => locale;
      set => locale = value;
  }

  [XmlElement("mediaRoutingPeripherals")]
  [XmlElement("mediaRoutingPeripheral")]
  public List<PeripheralWithRoutingClient>? MediaRoutingPeripherals
  {
      get => mediaRoutingPeripherals;
      set => mediaRoutingPeripherals = value;
  }

  public string? MrPG
  {
      get => mrPG;
      set => mrPG = value;
  }

  public int? OutboundEnabled
  {
      get => outboundEnabled;
      set => outboundEnabled = value;
  }

  [XmlElement("peripheralGatewaysRegistries")]
  [XmlElement("peripheralGatewaysRegistry")]
  public List<PeripheralGatewaysRegistry>? PeripheralGatewaysRegistries
  {
      get => peripheralGatewaysRegistries;
      set => peripheralGatewaysRegistries = value;
  }

  public string? UcmPG
  {
      get => ucmPG;
      set => ucmPG = value;
  }

  public string? UcmPGTIPPort
  {
      get => ucmPGTIPPort;
      set => ucmPGTIPPort = value;
  }

  public string? UcmPGTOSPort
  {
      get => ucmPGTOSPort;
      set => ucmPGTOSPort = value;
  }

  public string? VruPG
  {
      get => vruPG;
      set => vruPG = value;
  }

  // Path("registry")
  [XmlRoot("results")]
  public class RegistryList : BaseApiListBean<Registry> {    public override List<Registry>? GetItems() => items;

    public override void SetItems(List<Registry>? value) => items = value;

  }
}

}