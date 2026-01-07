using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("secondaryaddress")
[XmlRoot("peripheral")]
public class PeripheralWithRoutingClient : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private short? clientType;
  private string? correlationId;
  private ReferenceBean defaultDeskSetting;
  private ReferenceBean department;
  private bool? hideRefURL;
  private string? hostName1;
  private string? hostName2;
  private int? hostPort1;
  private int? hostPort2;
  private string? idFromRefUrl;
  private bool? markDeletable;
  private string? name;
  private ReferenceBean networkTarget;
  private ReferenceBean peripheralGateway;
  private int? peripheralId;
  private string? peripheralName;
  private RoutingClient routingClient;
  private int? routingClientId;
  private int? routingType;
  private string? routingTypeForMROnDC;

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

  public ReferenceBean DefaultDeskSetting
  {
      get => defaultDeskSetting;
      set => defaultDeskSetting = value;
  }

  public ReferenceBean Department
  {
      get => department;
      set => department = value;
  }

  public bool? HideRefURL
  {
      get => hideRefURL;
      set => hideRefURL = value;
  }

  public string? HostName1
  {
      get => hostName1;
      set => hostName1 = value;
  }

  public string? HostName2
  {
      get => hostName2;
      set => hostName2 = value;
  }

  public int? HostPort1
  {
      get => hostPort1;
      set => hostPort1 = value;
  }

  public int? HostPort2
  {
      get => hostPort2;
      set => hostPort2 = value;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
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

  public ReferenceBean NetworkTarget
  {
      get => networkTarget;
      set => networkTarget = value;
  }

  public ReferenceBean PeripheralGateway
  {
      get => peripheralGateway;
      set => peripheralGateway = value;
  }

  public int? PeripheralId
  {
      get => peripheralId;
      set => peripheralId = value;
  }

  public string? PeripheralName
  {
      get => peripheralName;
      set => peripheralName = value;
  }

  public RoutingClient RoutingClient
  {
      get => routingClient;
      set => routingClient = value;
  }

  public int? RoutingClientId
  {
      get => routingClientId;
      set => routingClientId = value;
  }

  public int? RoutingType
  {
      get => routingType;
      set => routingType = value;
  }

  public string? RoutingTypeForMROnDC
  {
      get => routingTypeForMROnDC;
      set => routingTypeForMROnDC = value;
  }

  // Path("secondaryaddress")
  [XmlRoot("results")]
  public class PeripheralWithRoutingClientList : BaseApiListBean<PeripheralWithRoutingClient> {    public override List<PeripheralWithRoutingClient>? GetItems() => items;

    public override void SetItems(List<PeripheralWithRoutingClient>? value) => items = value;

  }
}

}