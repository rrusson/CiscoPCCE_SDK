using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("weekDaySchedule")]
public class WeekDaySchedule : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private int? dayOfWeek;
  private ReferenceBean department;
  private string? endTime;
  private string? idFromRefUrl;
  private string? refURL;
  private string? startTime;

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

  public string? CorrelationId
  {
      get => correlationId;
      set => correlationId = value;
  }


  public void setCorrelationId(String correlationId) {
     this.correlationId = correlationId;
  }

  public int? DayOfWeek
  {
      get => dayOfWeek;
      set => dayOfWeek = value;
  }


  public void setDayOfWeek(int? dayOfWeek) {
     this.dayOfWeek = dayOfWeek;
  }

  public ReferenceBean Department
  {
      get => department;
      set => department = value;
  }


  public void setDepartment(ReferenceBean department) {
     this.department = department;
  }

  public string? EndTime
  {
      get => endTime;
      set => endTime = value;
  }


  public void setEndTime(String endTime) {
     this.endTime = endTime;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }


  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public string? StartTime
  {
      get => startTime;
      set => startTime = value;
  }


  public void setStartTime(String startTime) {
     this.startTime = startTime;
  }


}

}