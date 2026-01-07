using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("importContactSummary")]
public class ImportContactSummary : BaseApiBean {
                      
  public string? AccountNumber { get; set; }

  public string? BaseUrlfromRefUrl { get; set; }

  public int CallResultOverall { get; set; }

  [XmlElement("callStatus")]
  public CallStatusEnum CallStatusEnum { get; set; }

  public string? CorrelationId { get; set; }

  public ReferenceBean Department { get; set; }

  public string? FirstName { get; set; }

  public int? Id { get; set; }

  public string? IdFromRefUrl { get; set; }

  public string? LastName { get; set; }

  public string? RefURL { get; set; }

}

}