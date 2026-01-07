using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("peripheralSet")]
public class PeripheralSet : BaseApiBean {
                  
  public string? BaseUrlfromRefUrl { get; set; }

  public int? ChangeStamp { get; set; }

  public string? CorrelationId { get; set; }

  public ReferenceBean Department { get; set; }

  public string? Description { get; set; }

  public bool? EceConfigured { get; set; }

  public string? IdFromRefUrl { get; set; }

  public string? Name { get; set; }

  public string? RefURL { get; set; }

}

}