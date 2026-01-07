using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("precisionqueue")
[XmlRoot("precisionQueue")]
public class PrecisionQueue : BaseApiBean {
  private int? agentCount;
  private int? agentOrdering;
  private string? attribute1;
  private string? attribute2;
  private string? attribute3;
  private string? attribute4;
  private string? attribute5;
  private string? baseUrlfromRefUrl;
  private ReferenceBean bucketInterval;
  private int? callOrdering;
  private int? changeStamp;
  private string? correlationId;
  private ReferenceBean department;
  private string? description;
  private string? idFromRefUrl;
  private bool? markDeletable;
  private ReferenceBean mediaRoutingDomain;
  private string? name;
  private int? precisionQueueId;
  private string? refURL;
  private int? serviceLevelThreshold;
  private int? serviceLevelType;
  private List<SkillGroupWithPqId>? skillGroups;
  private List<Step>? steps;

  public int? AgentCount
  {
      get => agentCount;
      set => agentCount = value;
  }


  public void setAgentCount(int? agentCount) {
     this.agentCount = agentCount;
  }

  public int? AgentOrdering
  {
      get => agentOrdering;
      set => agentOrdering = value;
  }


  public void setAgentOrdering(int? agentOrdering) {
     this.agentOrdering = agentOrdering;
  }

  public string? Attribute1
  {
      get => attribute1;
      set => attribute1 = value;
  }


  public void setAttribute1(String attribute1) {
     this.attribute1 = attribute1;
  }

  public string? Attribute2
  {
      get => attribute2;
      set => attribute2 = value;
  }


  public void setAttribute2(String attribute2) {
     this.attribute2 = attribute2;
  }

  public string? Attribute3
  {
      get => attribute3;
      set => attribute3 = value;
  }


  public void setAttribute3(String attribute3) {
     this.attribute3 = attribute3;
  }

  public string? Attribute4
  {
      get => attribute4;
      set => attribute4 = value;
  }


  public void setAttribute4(String attribute4) {
     this.attribute4 = attribute4;
  }

  public string? Attribute5
  {
      get => attribute5;
      set => attribute5 = value;
  }


  public void setAttribute5(String attribute5) {
     this.attribute5 = attribute5;
  }

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

  public int? CallOrdering
  {
      get => callOrdering;
      set => callOrdering = value;
  }


  public void setCallOrdering(int? callOrdering) {
     this.callOrdering = callOrdering;
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

  public ReferenceBean MediaRoutingDomain
  {
      get => mediaRoutingDomain;
      set => mediaRoutingDomain = value;
  }


  public void setMediaRoutingDomain(ReferenceBean mediaRoutingDomain) {
     this.mediaRoutingDomain = mediaRoutingDomain;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }


  public void setName(String name) {
     this.name = name;
  }

  [XmlElement("id")]
  public int? PrecisionQueueId
  {
      get => precisionQueueId;
      set => precisionQueueId = value;
  }


  public void setPrecisionQueueId(int? precisionQueueId) {
     this.precisionQueueId = precisionQueueId;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
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

  [XmlElement("skillGroups")]
  [XmlElement("skillGroup")]
  public List<SkillGroupWithPqId>? SkillGroups
  {
      get => skillGroups;
      set => skillGroups = value;
  }


  public void setSkillGroups(List<SkillGroupWithPqId> skillGroups) {
     this.skillGroups = skillGroups;
  }

  [XmlElement("steps")]
  [XmlElement("step")]
  public List<Step>? Steps
  {
      get => steps;
      set => steps = value;
  }


  public void setSteps(List<Step> steps) {
     this.steps = steps;
  }


  // Path("precisionqueue")
  [XmlRoot("results")]
  public class PrecisionQueueList : BaseApiListBean<PrecisionQueue> {
    [XmlElement("precisionQueues")]
    [XmlElement("precisionQueue")]
   
    public override List<PrecisionQueue>? GetItems() => items;

    public override void SetItems(List<PrecisionQueue>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<PrecisionQueue>? items)
    {
        this.items = items;
    }
  }
}

}