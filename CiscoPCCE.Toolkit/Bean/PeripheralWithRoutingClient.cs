using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("secondaryaddress")
[XmlRoot("peripheral")]
public class PeripheralWithRoutingClient : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private Short clientType;
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

  public ReferenceBean DefaultDeskSetting
  {
      get => defaultDeskSetting;
      set => defaultDeskSetting = value;
  }


  public void setDefaultDeskSetting(ReferenceBean defaultDeskSetting) {
     this.defaultDeskSetting = defaultDeskSetting;
  }

  public ReferenceBean Department
  {
      get => department;
      set => department = value;
  }


  public void setDepartment(ReferenceBean department) {
     this.department = department;
  }

  public bool? HideRefURL
  {
      get => hideRefURL;
      set => hideRefURL = value;
  }


  public void setHideRefURL(bool? hideRefURL) {
     this.hideRefURL = hideRefURL;
  }

  public string? HostName1
  {
      get => hostName1;
      set => hostName1 = value;
  }


  public void setHostName1(String hostName1) {
     this.hostName1 = hostName1;
  }

  public string? HostName2
  {
      get => hostName2;
      set => hostName2 = value;
  }


  public void setHostName2(String hostName2) {
     this.hostName2 = hostName2;
  }

  public int? HostPort1
  {
      get => hostPort1;
      set => hostPort1 = value;
  }


  public void setHostPort1(int? hostPort1) {
     this.hostPort1 = hostPort1;
  }

  public int? HostPort2
  {
      get => hostPort2;
      set => hostPort2 = value;
  }


  public void setHostPort2(int? hostPort2) {
     this.hostPort2 = hostPort2;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }


  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
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

  public ReferenceBean NetworkTarget
  {
      get => networkTarget;
      set => networkTarget = value;
  }


  public void setNetworkTarget(ReferenceBean networkTarget) {
     this.networkTarget = networkTarget;
  }

  public ReferenceBean PeripheralGateway
  {
      get => peripheralGateway;
      set => peripheralGateway = value;
  }


  public void setPeripheralGateway(ReferenceBean peripheralGateway) {
     this.peripheralGateway = peripheralGateway;
  }

  public int? PeripheralId
  {
      get => peripheralId;
      set => peripheralId = value;
  }


  public void setPeripheralId(int? peripheralId) {
     this.peripheralId = peripheralId;
  }

  public string? PeripheralName
  {
      get => peripheralName;
      set => peripheralName = value;
  }


  public void setPeripheralName(String peripheralName) {
     this.peripheralName = peripheralName;
  }

  public RoutingClient RoutingClient
  {
      get => routingClient;
      set => routingClient = value;
  }


  public void setRoutingClient(RoutingClient routingClient) {
     this.routingClient = routingClient;
  }

  public int? RoutingClientId
  {
      get => routingClientId;
      set => routingClientId = value;
  }


  public void setRoutingClientId(int? routingClientId) {
     this.routingClientId = routingClientId;
  }

  public int? RoutingType
  {
      get => routingType;
      set => routingType = value;
  }


  public void setRoutingType(int? routingType) {
     this.routingType = routingType;
  }

  public string? RoutingTypeForMROnDC
  {
      get => routingTypeForMROnDC;
      set => routingTypeForMROnDC = value;
  }


  public void setRoutingTypeForMROnDC(String routingTypeForMROnDC) {
     this.routingTypeForMROnDC = routingTypeForMROnDC;
  }


  // Path("secondaryaddress")
  [XmlRoot("results")]
  public class PeripheralWithRoutingClientList : BaseApiListBean<PeripheralWithRoutingClient> {
    [XmlElement("peripherals")]
    [XmlElement("peripheral")]
   
    public override List<PeripheralWithRoutingClient>? GetItems() => items;

    public override void SetItems(List<PeripheralWithRoutingClient>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<PeripheralWithRoutingClient>? items)
    {
        this.items = items;
    }
  }
}

}