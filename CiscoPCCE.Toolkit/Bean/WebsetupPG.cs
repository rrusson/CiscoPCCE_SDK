using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("peripheralGateway")]
public class WebsetupPG : BaseApiBean {
  private string? logicalId;
  private string? pgClientType;
  private string? pgId;
  private List<WebsetupPim>? pims;
  private string? portIndex;
  private string? routerSideAPublicAddress;
  private string? routerSideBPublicAddress;
  private string? side;
  private string? sideAPrivateAddress;
  private string? sideAPublicAddress;
  private string? sideBPrivateAddress;
  private string? sideBPublicAddress;

  public string? LogicalId
  {
      get => logicalId;
      set => logicalId = value;
  }


  public void setLogicalId(String logicalId) {
     this.logicalId = logicalId;
  }

  public string? PgClientType
  {
      get => pgClientType;
      set => pgClientType = value;
  }


  public void setPgClientType(String pgClientType) {
     this.pgClientType = pgClientType;
  }

  public string? PgId
  {
      get => pgId;
      set => pgId = value;
  }


  public void setPgId(String pgId) {
     this.pgId = pgId;
  }

  [XmlElement("pims")]
  [XmlElement("pim")]
  public List<WebsetupPim>? Pims
  {
      get => pims;
      set => pims = value;
  }


  public void setPims(List<WebsetupPim> pims) {
     this.pims = pims;
  }

  public string? PortIndex
  {
      get => portIndex;
      set => portIndex = value;
  }


  public void setPortIndex(String portIndex) {
     this.portIndex = portIndex;
  }

  public string? RouterSideAPublicAddress
  {
      get => routerSideAPublicAddress;
      set => routerSideAPublicAddress = value;
  }


  public void setRouterSideAPublicAddress(String routerSideAPublicAddress) {
     this.routerSideAPublicAddress = routerSideAPublicAddress;
  }

  public string? RouterSideBPublicAddress
  {
      get => routerSideBPublicAddress;
      set => routerSideBPublicAddress = value;
  }


  public void setRouterSideBPublicAddress(String routerSideBPublicAddress) {
     this.routerSideBPublicAddress = routerSideBPublicAddress;
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