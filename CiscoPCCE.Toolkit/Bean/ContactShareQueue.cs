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

  public string? Name
  {
      get => name;
      set => name = value;
  }

  public string? QueueType
  {
      get => queueType;
      set => queueType = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  public ReferenceBean TargetInstance
  {
      get => targetInstance;
      set => targetInstance = value;
  }

  public int? TargetInstanceId
  {
      get => targetInstanceId;
      set => targetInstanceId = value;
  }

  public TargetQueue TargetQueue
  {
      get => targetQueue;
      set => targetQueue = value;
  }

  // Path("contactsharequeue")
  [XmlRoot("results")]
  public class ContactShareQueueList : BaseApiListBean<ContactShareQueue> {    public override List<ContactShareQueue>? GetItems() => items;

    public override void SetItems(List<ContactShareQueue>? value) => items = value;

  }
}

}