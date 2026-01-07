using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("ctiServer")]
public class WebsetupCtiServer : BaseApiBean {
  private string? cgId;
  private string? portIndex;
  private string? side;
  private string? sideAPrivateAddress;
  private string? sideAPublicAddress;
  private string? sideBPrivateAddress;
  private string? sideBPublicAddress;

  public string? CgId
  {
      get => cgId;
      set => cgId = value;
  }


  public void setCgId(String cgId) {
     this.cgId = cgId;
  }

  public string? PortIndex
  {
      get => portIndex;
      set => portIndex = value;
  }


  public void setPortIndex(String portIndex) {
     this.portIndex = portIndex;
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