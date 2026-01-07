using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("deploymenttypeinfo")
public class PeripheralBase : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private Short clientType;
  private string? correlationId;
  private ReferenceBean defaultDeskSetting;
  private ReferenceBean department;
  private string? hostName1;
  private string? hostName2;
  private int? hostPort1;
  private int? hostPort2;
  private string? idFromRefUrl;
  private bool? markDeletable;
  private string? name;
  private ReferenceBean networkTarget;
  private ReferenceBean peripheralGateway;
  private string? peripheralName;
  private string? refURL;

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

  public string? PeripheralName
  {
      get => peripheralName;
      set => peripheralName = value;
  }


  public void setPeripheralName(String peripheralName) {
     this.peripheralName = peripheralName;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }


}

}