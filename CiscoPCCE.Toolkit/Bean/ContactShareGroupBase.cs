using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("contactsharegroup")
public class ContactShareGroupBase : BaseApiBean {
                      
  public string? AcceptQueueIf { get; set; }

  public string? BaseUrlfromRefUrl { get; set; }

  public int? ChangeStamp { get; set; }

  public ReferenceBean ContactShareRule { get; set; }

  public string? CorrelationId { get; set; }

  public ReferenceBean Department { get; set; }

  public string? Description { get; set; }

  public string? IdFromRefUrl { get; set; }

  public string? Name { get; set; }

  public int? QueueCount { get; set; }

  public string? RefURL { get; set; }

}

}