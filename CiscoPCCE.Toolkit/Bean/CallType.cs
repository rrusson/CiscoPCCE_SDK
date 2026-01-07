using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("calltype")
[XmlRoot("callType")]
public class CallType : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private ReferenceBean bucketInterval;
  private int? callTypeId;
  private string? ccaiConfigID;
  private int? changeStamp;
  private string? correlationId;
  private ReferenceBean department;
  private string? description;
  private string? idFromRefUrl;
  private bool? markDeletable;
  private string? name;
  private string? refURL;
  private List<ScriptSchedule>? scriptSchedules;
  private int? serviceLevelThreshold;
  private int? serviceLevelType;

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }

  public ReferenceBean BucketInterval
  {
      get => bucketInterval;
      set => bucketInterval = value;
  }

  [XmlElement("id")]
  public int? CallTypeId
  {
      get => callTypeId;
      set => callTypeId = value;
  }

  public string? CcaiConfigID
  {
      get => ccaiConfigID;
      set => ccaiConfigID = value;
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

  public bool? MarkDeletable
  {
      get => markDeletable;
      set => markDeletable = value;
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

  [XmlElement("##default")]
  [XmlElement("scriptSchedule")]
  public List<ScriptSchedule>? ScriptSchedules
  {
      get => scriptSchedules;
      set => scriptSchedules = value;
  }

  public int? ServiceLevelThreshold
  {
      get => serviceLevelThreshold;
      set => serviceLevelThreshold = value;
  }

  public int? ServiceLevelType
  {
      get => serviceLevelType;
      set => serviceLevelType = value;
  }

  // Path("calltype")
  [XmlRoot("results")]
  public class CallTypeList : BaseApiListBean<CallType> {    public override List<CallType>? GetItems() => items;

    public override void SetItems(List<CallType>? value) => items = value;

  }
}

}