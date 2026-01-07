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

  public bool? Interruptible
  {
      get => interruptible;
      set => interruptible = value;
  }


  public void setInterruptible(Boolean interruptible) {
     this.interruptible = interruptible;
  }

  [XmlElement("id")]
  public int? MRDomainId
  {
      get => mRDomainId;
      set => mRDomainId = value;
  }


  public void setMRDomainId(int? mRDomainId) {
     this.mRDomainId = mRDomainId;
  }

  public int? MaxTaskDuration
  {
      get => maxTaskDuration;
      set => maxTaskDuration = value;
  }


  public void setMaxTaskDuration(int? maxTaskDuration) {
     this.maxTaskDuration = maxTaskDuration;
  }

  public int? MaxTasksInQueue
  {
      get => maxTasksInQueue;
      set => maxTasksInQueue = value;
  }


  public void setMaxTasksInQueue(int? maxTasksInQueue) {
     this.maxTasksInQueue = maxTasksInQueue;
  }

  public int? MaxTimeInQueue
  {
      get => maxTimeInQueue;
      set => maxTimeInQueue = value;
  }


  public void setMaxTimeInQueue(int? maxTimeInQueue) {
     this.maxTimeInQueue = maxTimeInQueue;
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

  public int? ServiceLevelThreshold
  {
      get => serviceLevelThreshold;
      set => serviceLevelThreshold = value;
  }


  public void setServiceLevelThreshold(int? serviceLevelThreshold) {
     this.serviceLevelThreshold = serviceLevelThreshold;
  }

  public int? TaskLife
  {
      get => taskLife;
      set => taskLife = value;
  }


  public void setTaskLife(int? taskLife) {
     this.taskLife = taskLife;
  }

  public int? TaskStartTimeout
  {
      get => taskStartTimeout;
      set => taskStartTimeout = value;
  }


  public void setTaskStartTimeout(int? taskStartTimeout) {
     this.taskStartTimeout = taskStartTimeout;
  }

  public MediaRoutingType Type
  {
      get => type;
      set => type = value;
  }


  public void setType(MediaRoutingType type) {
     this.type = type;
  }


  // Path("mediaroutingdomain")
  [XmlRoot("results")]
  public class MediaRoutingDomainList : BaseApiListBean<MediaRoutingDomain> {
    [XmlElement("mediaRoutingDomains")]
    [XmlElement("mediaRoutingDomain")]
   
    public override List<MediaRoutingDomain>? GetItems() => items;

    public override void SetItems(List<MediaRoutingDomain>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<MediaRoutingDomain>? items)
    {
        this.items = items;
    }
  }
}

}