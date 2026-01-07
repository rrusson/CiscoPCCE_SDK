using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("specialDaySchedule")]
public class SpecialDaySchedule : BaseApiBean {
  private string? date;

  public string? BaseUrlfromRefUrl { get; set; }

  public int? ChangeStamp { get; set; }

  public string? CorrelationId { get; set; }

  public string? Date
  {
      get => date;
      set => date = value;
  }

  public ReferenceBean Department { get; set; }

  public string? Description { get; set; }

  public string? EndTime { get; set; }

  public string? IdFromRefUrl { get; set; }

  public string? RefURL { get; set; }

  public string? StartTime { get; set; }

  public int? Status { get; set; }

  public ReferenceBean StatusReason { get; set; }

}

}