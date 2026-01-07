using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("icm")]
public class ICMServiceConfig : BaseApiBean {
  private bool? enableSecureVRU;
  private bool? enableTrunkUtilization;
  private string? gatewaylist;
  private List<ReferenceBean>? gateways;
  private int? maxDNISLength;
  private int? maxGatewayPorts;
  private int? vruConnectionPort;

  public bool? EnableSecureVRU
  {
      get => enableSecureVRU;
      set => enableSecureVRU = value;
  }


  public void setEnableSecureVRU(Boolean enableSecureVRU) {
     this.enableSecureVRU = enableSecureVRU;
  }

  public bool? EnableTrunkUtilization
  {
      get => enableTrunkUtilization;
      set => enableTrunkUtilization = value;
  }


  public void setEnableTrunkUtilization(Boolean enableTrunkUtilization) {
     this.enableTrunkUtilization = enableTrunkUtilization;
  }

  public string? Gatewaylist
  {
      get => gatewaylist;
      set => gatewaylist = value;
  }


  public void setGatewaylist(String gatewaylist) {
     this.gatewaylist = gatewaylist;
  }

  [XmlElement("gateways")]
  [XmlElement("gateway")]
  public List<ReferenceBean>? Gateways
  {
      get => gateways;
      set => gateways = value;
  }


  public void setGateways(List<ReferenceBean> gateways) {
     this.gateways = gateways;
  }

  public int? MaxDNISLength
  {
      get => maxDNISLength;
      set => maxDNISLength = value;
  }


  public void setMaxDNISLength(int? maxDNISLength) {
     this.maxDNISLength = maxDNISLength;
  }

  public int? MaxGatewayPorts
  {
      get => maxGatewayPorts;
      set => maxGatewayPorts = value;
  }


  public void setMaxGatewayPorts(int? maxGatewayPorts) {
     this.maxGatewayPorts = maxGatewayPorts;
  }

  public int? VruConnectionPort
  {
      get => vruConnectionPort;
      set => vruConnectionPort = value;
  }


  public void setVruConnectionPort(int? vruConnectionPort) {
     this.vruConnectionPort = vruConnectionPort;
  }


}

}