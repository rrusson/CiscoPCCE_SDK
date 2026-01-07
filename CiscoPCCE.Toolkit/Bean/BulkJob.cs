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
  private short? jobState;
  private short? jobType;
  private FileRef logFile;
  private string? refURL;
  private DateTime? startDateTime;

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

  public string? CorrelationId
  {
      get => correlationId;
      set => correlationId = value;
  }

  public DateTime? CreateDateTime
  {
      get => createDateTime;
      set => createDateTime = value;
  }

  public FileRef CsvFile
  {
      get => csvFile;
      set => csvFile = value;
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

  public DateTime? EndDateTime
  {
      get => endDateTime;
      set => endDateTime = value;
  }

  public string? FileContent
  {
      get => fileContent;
      set => fileContent = value;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }

  public string? JobHostName
  {
      get => jobHostName;
      set => jobHostName = value;
  }

  public short? JobState
  {
      get => jobState;
      set => jobState = value;
  }

  public short? JobType
  {
      get => jobType;
      set => jobType = value;
  }

  public FileRef LogFile
  {
      get => logFile;
      set => logFile = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  public DateTime? StartDateTime
  {
      get => startDateTime;
      set => startDateTime = value;
  }

  // Path("bulkjob")
  [XmlRoot("results")]
  public class BulkJobList : BaseApiListBean<BulkJob> {    public override List<BulkJob>? GetItems() => items;

    public override void SetItems(List<BulkJob>? value) => items = value;

  }
}

}