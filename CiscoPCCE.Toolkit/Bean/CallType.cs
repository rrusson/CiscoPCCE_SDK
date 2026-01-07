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


  public void setBaseUrlfromRefUrl(String baseUrlfromRefUrl) {
     this.baseUrlfromRefUrl = baseUrlfromRefUrl;
  }

  public ReferenceBean BucketInterval
  {
      get => bucketInterval;
      set => bucketInterval = value;
  }


  public void setBucketInterval(ReferenceBean bucketInterval) {
     this.bucketInterval = bucketInterval;
  }

  [XmlElement("id")]
  public int? CallTypeId
  {
      get => callTypeId;
      set => callTypeId = value;
  }


  public void setCallTypeId(int? callTypeId) {
     this.callTypeId = callTypeId;
  }

  public string? CcaiConfigID
  {
      get => ccaiConfigID;
      set => ccaiConfigID = value;
  }


  public void setCcaiConfigID(String ccaiConfigID) {
     this.ccaiConfigID = ccaiConfigID;
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

  public bool? MarkDeletable
  {
      get => markDeletable;
      set => markDeletable = value;
  }


  public void setMarkDeletable(Boolean markDeletable) {
     this.markDeletable = markDeletable;
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

  [XmlElement("##default")]
  [XmlElement("scriptSchedule")]
  public List<ScriptSchedule>? ScriptSchedules
  {
      get => scriptSchedules;
      set => scriptSchedules = value;
  }


  public void setScriptSchedules(List<ScriptSchedule> scriptSchedules) {
     this.scriptSchedules = scriptSchedules;
  }

  public int? ServiceLevelThreshold
  {
      get => serviceLevelThreshold;
      set => serviceLevelThreshold = value;
  }


  public void setServiceLevelThreshold(int? serviceLevelThreshold) {
     this.serviceLevelThreshold = serviceLevelThreshold;
  }

  public int? ServiceLevelType
  {
      get => serviceLevelType;
      set => serviceLevelType = value;
  }


  public void setServiceLevelType(int? serviceLevelType) {
     this.serviceLevelType = serviceLevelType;
  }


  // Path("calltype")
  [XmlRoot("results")]
  public class CallTypeList : BaseApiListBean<CallType> {
    [XmlElement("callTypes")]
    [XmlElement("callType")]
   
    public override List<CallType>? GetItems() => items;

    public override void SetItems(List<CallType>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<CallType>? items)
    {
        this.items = items;
    }
  }
}

}