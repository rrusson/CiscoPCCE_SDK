using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("secondaryaddress")
[XmlRoot("peripheralGateway")]
public class PeripheralGateway : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private Short clientType;
  private string? correlationId;
  private ReferenceBean datacenter;
  private ReferenceBean department;
  private string? idFromRefUrl;
  private int? logicalControllerId;
  private Short logicalControllerType;
  private bool? markDeletable;
  private string? name;
  private List<PeripheralWithRoutingClient>? peripherals;
  private string? primaryCtiAddress;
  private string? refURL;
  private string? secondaryCtiAddress;

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }


  public void setBaseUrlfromRefUrl(String baseUrlfromRefUrl) {
     this.baseUrlfromRefUrl = baseUrlfromRefUrl;
  }

  public int? ChangeStamp
  {
      get => changeStamp;
      set => changeStamp = value;
  }


  public void setChangeStamp(int? changeStamp) {
     this.changeStamp = changeStamp;
  }

  public Short ClientType
  {
      get => clientType;
      set => clientType = value;
  }


  public void setClientType(Short clientType) {
     this.clientType = clientType;
  }

  public string? CorrelationId
  {
      get => correlationId;
      set => correlationId = value;
  }


  public void setCorrelationId(String correlationId) {
     this.correlationId = correlationId;
  }

  public ReferenceBean Datacenter
  {
      get => datacenter;
      set => datacenter = value;
  }


  public void setDatacenter(ReferenceBean datacenter) {
     this.datacenter = datacenter;
  }

  public ReferenceBean Department
  {
      get => department;
      set => department = value;
  }


  public void setDepartment(ReferenceBean department) {
     this.department = department;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }


  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public int? LogicalControllerId
  {
      get => logicalControllerId;
      set => logicalControllerId = value;
  }


  public void setLogicalControllerId(int? logicalControllerId) {
     this.logicalControllerId = logicalControllerId;
  }

  public Short LogicalControllerType
  {
      get => logicalControllerType;
      set => logicalControllerType = value;
  }


  public void setLogicalControllerType(Short logicalControllerType) {
     this.logicalControllerType = logicalControllerType;
  }

  public bool? MarkDeletable
  {
      get => markDeletable;
      set => markDeletable = value;
  }


  public void setMarkDeletable(Boolean markDeletable) {
     this.markDeletable = markDeletable;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }


  public void setName(String name) {
     this.name = name;
  }

  [XmlElement("peripherals")]
  [XmlElement("peripheral")]
  public List<PeripheralWithRoutingClient>? Peripherals
  {
      get => peripherals;
      set => peripherals = value;
  }


  public void setPeripherals(List<PeripheralWithRoutingClient> peripherals) {
     this.peripherals = peripherals;
  }

  public string? PrimaryCtiAddress
  {
      get => primaryCtiAddress;
      set => primaryCtiAddress = value;
  }


  public void setPrimaryCtiAddress(String primaryCtiAddress) {
     this.primaryCtiAddress = primaryCtiAddress;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public string? SecondaryCtiAddress
  {
      get => secondaryCtiAddress;
      set => secondaryCtiAddress = value;
  }


  public void setSecondaryCtiAddress(String secondaryCtiAddress) {
     this.secondaryCtiAddress = secondaryCtiAddress;
  }


  // Path("secondaryaddress")
  [XmlRoot("results")]
  public class PeripheralGatewayList : BaseApiListBean<PeripheralGateway> {
    [XmlElement("peripheralGateways")]
    [XmlElement("peripheralGateway")]
   
    public override List<PeripheralGateway>? GetItems() => items;

    public override void SetItems(List<PeripheralGateway>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<PeripheralGateway>? items)
    {
        this.items = items;
    }
  }
}

}