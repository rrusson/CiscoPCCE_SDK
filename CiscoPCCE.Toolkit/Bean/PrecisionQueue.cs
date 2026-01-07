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

  public int? AgentOrdering
  {
      get => agentOrdering;
      set => agentOrdering = value;
  }

  public string? Attribute1
  {
      get => attribute1;
      set => attribute1 = value;
  }

  public string? Attribute2
  {
      get => attribute2;
      set => attribute2 = value;
  }

  public string? Attribute3
  {
      get => attribute3;
      set => attribute3 = value;
  }

  public string? Attribute4
  {
      get => attribute4;
      set => attribute4 = value;
  }

  public string? Attribute5
  {
      get => attribute5;
      set => attribute5 = value;
  }

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

  public int? CallOrdering
  {
      get => callOrdering;
      set => callOrdering = value;
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

  public ReferenceBean MediaRoutingDomain
  {
      get => mediaRoutingDomain;
      set => mediaRoutingDomain = value;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }

  [XmlElement("id")]
  public int? PrecisionQueueId
  {
      get => precisionQueueId;
      set => precisionQueueId = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
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

  [XmlElement("skillGroups")]
  [XmlElement("skillGroup")]
  public List<SkillGroupWithPqId>? SkillGroups
  {
      get => skillGroups;
      set => skillGroups = value;
  }

  [XmlElement("steps")]
  [XmlElement("step")]
  public List<Step>? Steps
  {
      get => steps;
      set => steps = value;
  }

  // Path("precisionqueue")
  [XmlRoot("results")]
  public class PrecisionQueueList : BaseApiListBean<PrecisionQueue> {    public override List<PrecisionQueue>? GetItems() => items;

    public override void SetItems(List<PrecisionQueue>? value) => items = value;

  }
}

}