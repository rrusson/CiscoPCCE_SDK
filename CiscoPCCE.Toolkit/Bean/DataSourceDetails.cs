using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

public class DataSourceDetails : BaseApiBean {
                  
  public DataSourceAddressRef Address { get; set; }

  public string? BaseUrlfromRefUrl { get; set; }

  public string? CorrelationId { get; set; }

  public ReferenceBean Department { get; set; }

  public int? Id { get; set; }

  public string? IdFromRefUrl { get; set; }

  public string? Password { get; set; }

  public string? RefURL { get; set; }

  public string? UserName { get; set; }

}

}