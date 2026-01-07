using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("regionprefix")]
public class RegionPrefix : BaseApiBean {
                      
  public string? BaseUrlfromRefUrl { get; set; }

  public int? ChangeStamp { get; set; }

  public string? CorrelationId { get; set; }

  public Timestamp DateTimeStamp { get; set; }

  public bool? DaylightSavingEnabled { get; set; }

  public ReferenceBean Department { get; set; }

  public int? Gmt { get; set; }

  public string? IdFromRefUrl { get; set; }

  public string? RefURL { get; set; }

  public int? RegionId { get; set; }

  public string? RegionPrefixValue { get; set; }

}

}