using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("contactsharequeue")
[XmlRoot("contactShareQueue")]
public class ContactShareQueue : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private ReferenceBean department;
  private string? description;
  private string? idFromRefUrl;
  private string? name;
  private string? queueType;
  private string? refURL;
  private ReferenceBean targetInstance;
  private int? targetInstanceId;
  private TargetQueue targetQueue;

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

  public string? Name
  {
      get => name;
      set => name = value;
  }


  public void setName(String name) {
     this.name = name;
  }

  public string? QueueType
  {
      get => queueType;
      set => queueType = value;
  }


  public void setQueueType(String queueType) {
     this.queueType = queueType;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public ReferenceBean TargetInstance
  {
      get => targetInstance;
      set => targetInstance = value;
  }


  public void setTargetInstance(ReferenceBean targetInstance) {
     this.targetInstance = targetInstance;
  }

  public int? TargetInstanceId
  {
      get => targetInstanceId;
      set => targetInstanceId = value;
  }


  public void setTargetInstanceId(int? targetInstanceId) {
     this.targetInstanceId = targetInstanceId;
  }

  public TargetQueue TargetQueue
  {
      get => targetQueue;
      set => targetQueue = value;
  }


  public void setTargetQueue(TargetQueue targetQueue) {
     this.targetQueue = targetQueue;
  }


  // Path("contactsharequeue")
  [XmlRoot("results")]
  public class ContactShareQueueList : BaseApiListBean<ContactShareQueue> {
    [XmlElement("contactShareQueues")]
    [XmlElement("contactShareQueue")]
   
    public override List<ContactShareQueue>? GetItems() => items;

    public override void SetItems(List<ContactShareQueue>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<ContactShareQueue>? items)
    {
        this.items = items;
    }
  }
}

}