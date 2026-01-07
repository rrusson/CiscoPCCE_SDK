using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("survey")]
public class Survey : BaseApiBean {
                      
  public string? Application { get; set; }

  public string? BaseUrlfromRefUrl { get; set; }

  public int? ChangeStamp { get; set; }

  public string? CorrelationId { get; set; }

  public ReferenceBean Department { get; set; }

  public string? EnterpriseName { get; set; }

  public string? IdFromRefUrl { get; set; }

  public bool? MarkDeletable { get; set; }

  [XmlElement("surveyDetail")]
  public SurveyQuestion Question { get; set; }

  public string? RefURL { get; set; }

  public int? SurveyType { get; set; }

}

}