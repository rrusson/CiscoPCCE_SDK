using System.Xml.Serialization;
using System.Collections.Generic;
using System;

namespace CiscoPCCE.Toolkit.Bean
{





public class ScriptSchedule : BaseApiBean {
  private string? baseUrl;
  private int? day;
  private DayPosition dayPosition;
  private DayType dayType;
  private string? description;
  private DateTime? endDate;
  private DateTime? endTime;
  private ReferenceBean masterScript;
  private int? month;
  private ScheduleType scheduleType;
  private DateTime? startDate;
  private DateTime? startTime;
  private List<int?>? weekDays;

  public string? BaseUrl
  {
      get => baseUrl;
      set => baseUrl = value;
  }


  public void setBaseUrl(String baseUrl) {
     this.baseUrl = baseUrl;
  }

  public int? Day
  {
      get => day;
      set => day = value;
  }


  public void setDay(int? day) {
     this.day = day;
  }

  public DayPosition DayPosition
  {
      get => dayPosition;
      set => dayPosition = value;
  }


  public void setDayPosition(DayPosition dayPosition) {
     this.dayPosition = dayPosition;
  }

  public DayType DayType
  {
      get => dayType;
      set => dayType = value;
  }


  public void setDayType(DayType dayType) {
     this.dayType = dayType;
  }

  public string? Description
  {
      get => description;
      set => description = value;
  }


  public void setDescription(String description) {
     this.description = description;
  }

  public DateTime? EndDate
  {
      get => endDate;
      set => endDate = value;
  }


  public void setEndDate(Date endDate) {
     this.endDate = endDate;
  }

  public DateTime? EndTime
  {
      get => endTime;
      set => endTime = value;
  }


  public void setEndTime(Date endTime) {
     this.endTime = endTime;
  }

  public ReferenceBean MasterScript
  {
      get => masterScript;
      set => masterScript = value;
  }


  public void setMasterScript(ReferenceBean masterScript) {
     this.masterScript = masterScript;
  }

  public int? Month
  {
      get => month;
      set => month = value;
  }


  public void setMonth(int? month) {
     this.month = month;
  }

  public ScheduleType ScheduleType
  {
      get => scheduleType;
      set => scheduleType = value;
  }


  public void setScheduleType(ScheduleType scheduleType) {
     this.scheduleType = scheduleType;
  }

  public DateTime? StartDate
  {
      get => startDate;
      set => startDate = value;
  }


  public void setStartDate(Date startDate) {
     this.startDate = startDate;
  }

  public DateTime? StartTime
  {
      get => startTime;
      set => startTime = value;
  }


  public void setStartTime(Date startTime) {
     this.startTime = startTime;
  }

  [XmlElement("weekDays")]
  [XmlElement("weekDay")]
  public List<int?>? WeekDays
  {
      get => weekDays;
      set => weekDays = value;
  }


  public void setWeekDays(List<int?> weekDays) {
     this.weekDays = weekDays;
  }


}

}