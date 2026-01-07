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


  public void setBaseUrlfromRefUrl(String baseUrlfromRefUrl) {
     this.baseUrlfromRefUrl = baseUrlfromRefUrl;
  }

  public int? ChangeStamp
  {
      get => changeStamp;
      set => changeStamp = value;
  }


  public void setChangeStamp(int? changeStamp) {
     this.changeStamp = changeStamp;
  }

  public BusinessHourConfiguredStatus ConfiguredStatus
  {
      get => configuredStatus;
      set => configuredStatus = value;
  }


  public void setConfiguredStatus(BusinessHourConfiguredStatus configuredStatus) {
     this.configuredStatus = configuredStatus;
  }

  public string? CorrelationId
  {
      get => correlationId;
      set => correlationId = value;
  }


  public void setCorrelationId(String correlationId) {
     this.correlationId = correlationId;
  }

  public ReferenceBean Department
  {
      get => department;
      set => department = value;
  }


  public void setDepartment(ReferenceBean department) {
     this.department = department;
  }

  public string? Description
  {
      get => description;
      set => description = value;
  }


  public void setDescription(String description) {
     this.description = description;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }


  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }


  public void setName(String name) {
     this.name = name;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public int? RunTimeStatus
  {
      get => runTimeStatus;
      set => runTimeStatus = value;
  }


  public void setRunTimeStatus(int? runTimeStatus) {
     this.runTimeStatus = runTimeStatus;
  }

  public string? RunTimeStatusReason
  {
      get => runTimeStatusReason;
      set => runTimeStatusReason = value;
  }


  public void setRunTimeStatusReason(String runTimeStatusReason) {
     this.runTimeStatusReason = runTimeStatusReason;
  }

  [XmlElement("specialDaySchedules")]
  [XmlElement("specialDaySchedule")]
  public List<SpecialDaySchedule>? SpecialDaySchedules
  {
      get => specialDaySchedules;
      set => specialDaySchedules = value;
  }


  public void setSpecialDaySchedules(List<SpecialDaySchedule> specialDaySchedules) {
     this.specialDaySchedules = specialDaySchedules;
  }

  public ReferenceBean Timezone
  {
      get => timezone;
      set => timezone = value;
  }


  public void setTimezone(ReferenceBean timezone) {
     this.timezone = timezone;
  }

  public int? Type
  {
      get => type;
      set => type = value;
  }


  public void setType(int? type) {
     this.type = type;
  }

  [XmlElement("weekDaySchedules")]
  [XmlElement("weekDaySchedule")]
  public List<WeekDaySchedule>? WeekDaySchedules
  {
      get => weekDaySchedules;
      set => weekDaySchedules = value;
  }


  public void setWeekDaySchedules(List<WeekDaySchedule> weekDaySchedules) {
     this.weekDaySchedules = weekDaySchedules;
  }


  // Path("businesshour")
  [XmlRoot("results")]
  public class BusinessHourList : BaseApiListBean<BusinessHour> {
    [XmlElement("businessHours")]
    [XmlElement("businessHour")]
   
    public override List<BusinessHour>? GetItems() => items;

    public override void SetItems(List<BusinessHour>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<BusinessHour>? items)
    {
        this.items = items;
    }
  }
}

}