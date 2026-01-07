using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("router")]
public class WebsetupRouter : BaseApiBean {
  private string? enabledPeripheralGateways;
  private string? side;
  private string? sideAPrivateAddress;
  private string? sideAPublicAddress;
  private string? sideBPrivateAddress;
  private string? sideBPublicAddress;

  public string? EnabledPeripheralGateways
  {
      get => enabledPeripheralGateways;
      set => enabledPeripheralGateways = value;
  }


  public void setEnabledPeripheralGateways(String enabledPeripheralGateways) {
     this.enabledPeripheralGateways = enabledPeripheralGateways;
  }

  public string? Side
  {
      get => side;
      set => side = value;
  }


  public void setSide(String side) {
     this.side = side;
  }

  public string? SideAPrivateAddress
  {
      get => sideAPrivateAddress;
      set => sideAPrivateAddress = value;
  }


  public void setSideAPrivateAddress(String sideAPrivateAddress) {
     this.sideAPrivateAddress = sideAPrivateAddress;
  }

  public string? SideAPublicAddress
  {
      get => sideAPublicAddress;
      set => sideAPublicAddress = value;
  }


  public void setSideAPublicAddress(String sideAPublicAddress) {
     this.sideAPublicAddress = sideAPublicAddress;
  }

  public string? SideBPrivateAddress
  {
      get => sideBPrivateAddress;
      set => sideBPrivateAddress = value;
  }


  public void setSideBPrivateAddress(String sideBPrivateAddress) {
     this.sideBPrivateAddress = sideBPrivateAddress;
  }

  public string? SideBPublicAddress
  {
      get => sideBPublicAddress;
      set => sideBPublicAddress = value;
  }


  public void setSideBPublicAddress(String sideBPublicAddress) {
     this.sideBPublicAddress = sideBPublicAddress;
  }


}

}