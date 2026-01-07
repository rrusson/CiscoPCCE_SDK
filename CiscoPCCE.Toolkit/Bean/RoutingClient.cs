using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("secondaryaddress")
[XmlRoot("routingClient")]
public class RoutingClient : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private Short clientType;
  private string? correlationId;
  private ReferenceBean department;
  private string? idFromRefUrl;
  private Short lateThreshold;
  private ReferenceBean logicalController;
  private bool? markDeletable;
  private string? name;
  private PeripheralRef peripheral;
  private string? refURL;
  private Short timeoutLimit;
  private Short timeoutThreshold;

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

  public Short LateThreshold
  {
      get => lateThreshold;
      set => lateThreshold = value;
  }


  public void setLateThreshold(Short lateThreshold) {
     this.lateThreshold = lateThreshold;
  }

  public ReferenceBean LogicalController
  {
      get => logicalController;
      set => logicalController = value;
  }


  public void setLogicalController(ReferenceBean logicalController) {
     this.logicalController = logicalController;
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

  public PeripheralRef Peripheral
  {
      get => peripheral;
      set => peripheral = value;
  }


  public void setPeripheral(PeripheralRef peripheral) {
     this.peripheral = peripheral;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public Short TimeoutLimit
  {
      get => timeoutLimit;
      set => timeoutLimit = value;
  }


  public void setTimeoutLimit(Short timeoutLimit) {
     this.timeoutLimit = timeoutLimit;
  }

  public Short TimeoutThreshold
  {
      get => timeoutThreshold;
      set => timeoutThreshold = value;
  }


  public void setTimeoutThreshold(Short timeoutThreshold) {
     this.timeoutThreshold = timeoutThreshold;
  }


  // Path("secondaryaddress")
  [XmlRoot("results")]
  public class RoutingClientList : BaseApiListBean<RoutingClient> {
    [XmlElement("routingClients")]
    [XmlElement("routingClient")]
   
    public override List<RoutingClient>? GetItems() => items;

    public override void SetItems(List<RoutingClient>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<RoutingClient>? items)
    {
        this.items = items;
    }
  }
}

}