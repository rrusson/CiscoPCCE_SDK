using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





public class PeripheralGatewaysRegistry : BaseApiBean {
  private string? clientType;
  private int? logicalControllerID;
  private List<PeripheralWithRoutingClient>? peripheralDetails;
  private string? pgName;

  public string? ClientType
  {
      get => clientType;
      set => clientType = value;
  }


  public void setClientType(String clientType) {
     this.clientType = clientType;
  }

  public int? LogicalControllerID
  {
      get => logicalControllerID;
      set => logicalControllerID = value;
  }


  public void setLogicalControllerID(int? logicalControllerID) {
     this.logicalControllerID = logicalControllerID;
  }

  [XmlElement("peripherals")]
  [XmlElement("peripheral")]
  public List<PeripheralWithRoutingClient>? PeripheralDetails
  {
      get => peripheralDetails;
      set => peripheralDetails = value;
  }


  public void setPeripheralDetails(List<PeripheralWithRoutingClient> peripheralDetails) {
     this.peripheralDetails = peripheralDetails;
  }

  public string? PgName
  {
      get => pgName;
      set => pgName = value;
  }


  public void setPgName(String pgName) {
     this.pgName = pgName;
  }


}

}