using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("secondaryaddress")
[XmlRoot("routingClient")]
public class RoutingClient : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private short? clientType;
  private string? correlationId;
  private ReferenceBean department;
  private string? idFromRefUrl;
  private short? lateThreshold;
  private ReferenceBean logicalController;
  private bool? markDeletable;
  private string? name;
  private PeripheralRef peripheral;
  private string? refURL;
  private short? timeoutLimit;
  private short? timeoutThreshold;

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }

  public int? ChangeStamp
  {
      get => changeStamp;
      set => changeStamp = value;
  }

  public short? ClientType
  {
      get => clientType;
      set => clientType = value;
  }

  public string? CorrelationId
  {
      get => correlationId;
      set => correlationId = value;
  }

  public ReferenceBean Department
  {
      get => department;
      set => department = value;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }

  public short? LateThreshold
  {
      get => lateThreshold;
      set => lateThreshold = value;
  }

  public ReferenceBean LogicalController
  {
      get => logicalController;
      set => logicalController = value;
  }

  public bool? MarkDeletable
  {
      get => markDeletable;
      set => markDeletable = value;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }

  public PeripheralRef Peripheral
  {
      get => peripheral;
      set => peripheral = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  public short? TimeoutLimit
  {
      get => timeoutLimit;
      set => timeoutLimit = value;
  }

  public short? TimeoutThreshold
  {
      get => timeoutThreshold;
      set => timeoutThreshold = value;
  }

  // Path("secondaryaddress")
  [XmlRoot("results")]
  public class RoutingClientList : BaseApiListBean<RoutingClient> {    public override List<RoutingClient>? GetItems() => items;

    public override void SetItems(List<RoutingClient>? value) => items = value;

  }
}

}