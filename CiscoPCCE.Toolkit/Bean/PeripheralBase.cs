using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("deploymenttypeinfo")
public class PeripheralBase : BaseApiBean {
                                  
  public string? BaseUrlfromRefUrl { get; set; }

  public int? ChangeStamp { get; set; }

  public short? ClientType { get; set; }

  public string? CorrelationId { get; set; }

  public ReferenceBean DefaultDeskSetting { get; set; }

  public ReferenceBean Department { get; set; }

  public string? HostName1 { get; set; }

  public string? HostName2 { get; set; }

  public int? HostPort1 { get; set; }

  public int? HostPort2 { get; set; }

  public string? IdFromRefUrl { get; set; }

  public bool? MarkDeletable { get; set; }

  public string? Name { get; set; }

  public ReferenceBean NetworkTarget { get; set; }

  public ReferenceBean PeripheralGateway { get; set; }

  public string? PeripheralName { get; set; }

  public string? RefURL { get; set; }

}

}