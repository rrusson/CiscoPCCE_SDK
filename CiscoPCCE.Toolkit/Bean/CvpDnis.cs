using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("cvpDnis")]
public class CvpDnis : BaseApiBean {
                  
  public string? BaseUrlfromRefUrl { get; set; }

  public string? CorrelationId { get; set; }

  public ReferenceBean Datacenter { get; set; }

  public ReferenceBean Department { get; set; }

  public string? DnisList { get; set; }

  public string? Hostname { get; set; }

  public int? Id { get; set; }

  public string? IdFromRefUrl { get; set; }

  public string? RefURL { get; set; }

}

}