using System.Xml.Serialization;
using System.Collections.Generic;
using System;

namespace CiscoPCCE.Toolkit.Bean
{

public class ScriptSchedule : BaseApiBean {
                          
  public string? BaseUrl { get; set; }

  public int? Day { get; set; }

  public DayPosition DayPosition { get; set; }

  public DayType DayType { get; set; }

  public string? Description { get; set; }

  public DateTime? EndDate { get; set; }

  public DateTime? EndTime { get; set; }

  public ReferenceBean MasterScript { get; set; }

  public int? Month { get; set; }

  public ScheduleType ScheduleType { get; set; }

  public DateTime? StartDate { get; set; }

  public DateTime? StartTime { get; set; }

  [XmlElement("weekDays")]
  [XmlElement("weekDay")]
  public List<int?>? WeekDays { get; set; }

}

}