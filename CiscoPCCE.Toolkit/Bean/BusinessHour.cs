using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("businesshour")
[XmlRoot("businessHour")]
public class BusinessHour : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private BusinessHourConfiguredStatus configuredStatus;
  private string? correlationId;
  private ReferenceBean department;
  private string? description;
  private string? idFromRefUrl;
  private string? name;
  private string? refURL;
  private int? runTimeStatus;
  private string? runTimeStatusReason;
  private List<SpecialDaySchedule>? specialDaySchedules;
  private ReferenceBean timezone;
  private int? type;
  private List<WeekDaySchedule>? weekDaySchedules;

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }

  public int? ChangeStamp
  {
      get => changeStamp;
      set => changeStamp = value;
  }

  public BusinessHourConfiguredStatus ConfiguredStatus
  {
      get => configuredStatus;
      set => configuredStatus = value;
  }

  public string? CorrelationId
  {
      get => correlationId;
      set => correlationId = value;
  }

  public ReferenceBean Department
  {
      get => department;
      set => department = value;
  }

  public string? Description
  {
      get => description;
      set => description = value;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  public int? RunTimeStatus
  {
      get => runTimeStatus;
      set => runTimeStatus = value;
  }

  public string? RunTimeStatusReason
  {
      get => runTimeStatusReason;
      set => runTimeStatusReason = value;
  }

  [XmlElement("specialDaySchedules")]
  [XmlElement("specialDaySchedule")]
  public List<SpecialDaySchedule>? SpecialDaySchedules
  {
      get => specialDaySchedules;
      set => specialDaySchedules = value;
  }

  public ReferenceBean Timezone
  {
      get => timezone;
      set => timezone = value;
  }

  public int? Type
  {
      get => type;
      set => type = value;
  }

  [XmlElement("weekDaySchedules")]
  [XmlElement("weekDaySchedule")]
  public List<WeekDaySchedule>? WeekDaySchedules
  {
      get => weekDaySchedules;
      set => weekDaySchedules = value;
  }

  // Path("businesshour")
  [XmlRoot("results")]
  public class BusinessHourList : BaseApiListBean<BusinessHour> {    public override List<BusinessHour>? GetItems() => items;

    public override void SetItems(List<BusinessHour>? value) => items = value;

  }
}

}