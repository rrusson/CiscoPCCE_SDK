using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("datacenter")]
public class DataCenter12k : BaseApiBean {
              
  public string? BaseUrlfromRefUrl { get; set; }

  public int? ChangeStamp { get; set; }

  public string? CorrelationId { get; set; }

  public ReferenceBean Department { get; set; }

  public string? IdFromRefUrl { get; set; }

  public string? Name { get; set; }

  public string? RefURL { get; set; }

}

}