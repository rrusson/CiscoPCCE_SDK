using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("mediaroutingdomain")
[XmlRoot("mediaRoutingDomain")]
public class MediaRoutingDomain : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private ReferenceBean department;
  private string? description;
  private string? idFromRefUrl;
  private bool? interruptible;
  private int? mRDomainId;
  private int? maxTaskDuration;
  private int? maxTasksInQueue;
  private int? maxTimeInQueue;
  private string? name;
  private string? refURL;
  private int? serviceLevelThreshold;
  private int? taskLife;
  private int? taskStartTimeout;
  private MediaRoutingType type;

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

  public bool? Interruptible
  {
      get => interruptible;
      set => interruptible = value;
  }

  [XmlElement("id")]
  public int? MRDomainId
  {
      get => mRDomainId;
      set => mRDomainId = value;
  }

  public int? MaxTaskDuration
  {
      get => maxTaskDuration;
      set => maxTaskDuration = value;
  }

  public int? MaxTasksInQueue
  {
      get => maxTasksInQueue;
      set => maxTasksInQueue = value;
  }

  public int? MaxTimeInQueue
  {
      get => maxTimeInQueue;
      set => maxTimeInQueue = value;
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

  public int? ServiceLevelThreshold
  {
      get => serviceLevelThreshold;
      set => serviceLevelThreshold = value;
  }

  public int? TaskLife
  {
      get => taskLife;
      set => taskLife = value;
  }

  public int? TaskStartTimeout
  {
      get => taskStartTimeout;
      set => taskStartTimeout = value;
  }

  public MediaRoutingType Type
  {
      get => type;
      set => type = value;
  }

  // Path("mediaroutingdomain")
  [XmlRoot("results")]
  public class MediaRoutingDomainList : BaseApiListBean<MediaRoutingDomain> {    public override List<MediaRoutingDomain>? GetItems() => items;

    public override void SetItems(List<MediaRoutingDomain>? value) => items = value;

  }
}

}