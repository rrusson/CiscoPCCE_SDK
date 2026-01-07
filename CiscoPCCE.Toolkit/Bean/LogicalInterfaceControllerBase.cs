using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("globalsetting")
public class LogicalInterfaceControllerBase : BaseApiBean {
                        
  public string? BaseUrlfromRefUrl { get; set; }

  public int? ChangeStamp { get; set; }

  public short? ClientType { get; set; }

  public string? CorrelationId { get; set; }

  public ReferenceBean Department { get; set; }

  public string? IdFromRefUrl { get; set; }

  public short? LogicalControllerType { get; set; }

  public bool? MarkDeletable { get; set; }

  public string? Name { get; set; }

  public string? PrimaryCtiAddress { get; set; }

  public string? RefURL { get; set; }

  public string? SecondaryCtiAddress { get; set; }

}

}