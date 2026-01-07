using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

public class DataSourceAddressRef : BaseApiBean {
              
  public string? BaseUrlfromRefUrl { get; set; }

  public string? CorrelationId { get; set; }

  public ReferenceBean Department { get; set; }

  public string? HostName { get; set; }

  public int? Id { get; set; }

  public string? IdFromRefUrl { get; set; }

  public string? RefURL { get; set; }

}

}