using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("specialDaySchedule")]
public class SpecialDaySchedule : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private string? date;
  private ReferenceBean department;
  private string? description;
  private string? endTime;
  private string? idFromRefUrl;
  private string? refURL;
  private string? startTime;
  private int? status;
  private ReferenceBean statusReason;

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

  public string? Date
  {
      get => date;
      set => date = value;
  }


  public void setDate(String date) {
     this.date = date;
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

  public int? Status
  {
      get => status;
      set => status = value;
  }


  public void setStatus(int? status) {
     this.status = status;
  }

  public ReferenceBean StatusReason
  {
      get => statusReason;
      set => statusReason = value;
  }


  public void setStatusReason(ReferenceBean statusReason) {
     this.statusReason = statusReason;
  }


}

}