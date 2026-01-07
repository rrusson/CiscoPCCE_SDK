using System.Xml.Serialization;
using System.Collections.Generic;
using System;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("bulkjob")
[XmlRoot("bulkJob")]
public class BulkJob : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private DateTime? createDateTime;
  private FileRef csvFile;
  private ReferenceBean department;
  private string? description;
  private DateTime? endDateTime;
  private string? fileContent;
  private string? idFromRefUrl;
  private string? jobHostName;
  private Short jobState;
  private Short jobType;
  private FileRef logFile;
  private string? refURL;
  private DateTime? startDateTime;

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

  public DateTime? CreateDateTime
  {
      get => createDateTime;
      set => createDateTime = value;
  }


  public void setCreateDateTime(Date createDateTime) {
     this.createDateTime = createDateTime;
  }

  public FileRef CsvFile
  {
      get => csvFile;
      set => csvFile = value;
  }


  public void setCsvFile(FileRef csvFile) {
     this.csvFile = csvFile;
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

  public DateTime? EndDateTime
  {
      get => endDateTime;
      set => endDateTime = value;
  }


  public void setEndDateTime(Date endDateTime) {
     this.endDateTime = endDateTime;
  }

  public string? FileContent
  {
      get => fileContent;
      set => fileContent = value;
  }


  public void setFileContent(String fileContent) {
     this.fileContent = fileContent;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }


  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public string? JobHostName
  {
      get => jobHostName;
      set => jobHostName = value;
  }


  public void setJobHostName(String jobHostName) {
     this.jobHostName = jobHostName;
  }

  public Short JobState
  {
      get => jobState;
      set => jobState = value;
  }


  public void setJobState(Short jobState) {
     this.jobState = jobState;
  }

  public Short JobType
  {
      get => jobType;
      set => jobType = value;
  }


  public void setJobType(Short jobType) {
     this.jobType = jobType;
  }

  public FileRef LogFile
  {
      get => logFile;
      set => logFile = value;
  }


  public void setLogFile(FileRef logFile) {
     this.logFile = logFile;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public DateTime? StartDateTime
  {
      get => startDateTime;
      set => startDateTime = value;
  }


  public void setStartDateTime(Date startDateTime) {
     this.startDateTime = startDateTime;
  }


  // Path("bulkjob")
  [XmlRoot("results")]
  public class BulkJobList : BaseApiListBean<BulkJob> {
    [XmlElement("bulkJobs")]
    [XmlElement("bulkJob")]
   
    public override List<BulkJob>? GetItems() => items;

    public override void SetItems(List<BulkJob>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<BulkJob>? items)
    {
        this.items = items;
    }
  }
}

}