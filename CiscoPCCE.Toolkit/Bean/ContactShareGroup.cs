using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("contactsharegroup")
[XmlRoot("contactShareGroup")]
public class ContactShareGroup : BaseApiBean {
  private string? acceptQueueIf;
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private List<ReferenceBean>? contactShareQueues;
  private ReferenceBean contactShareRule;
  private string? correlationId;
  private ReferenceBean department;
  private string? description;
  private string? idFromRefUrl;
  private string? name;
  private int? queueCount;
  private string? refURL;

  public string? AcceptQueueIf
  {
      get => acceptQueueIf;
      set => acceptQueueIf = value;
  }


  public void setAcceptQueueIf(String acceptQueueIf) {
     this.acceptQueueIf = acceptQueueIf;
  }

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

  [XmlElement("contactShareQueues")]
  [XmlElement("contactShareQueue")]
  public List<ReferenceBean>? ContactShareQueues
  {
      get => contactShareQueues;
      set => contactShareQueues = value;
  }


  public void setContactShareQueues(List<ReferenceBean> contactShareQueues) {
     this.contactShareQueues = contactShareQueues;
  }

  public ReferenceBean ContactShareRule
  {
      get => contactShareRule;
      set => contactShareRule = value;
  }


  public void setContactShareRule(ReferenceBean contactShareRule) {
     this.contactShareRule = contactShareRule;
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

  public int? QueueCount
  {
      get => queueCount;
      set => queueCount = value;
  }


  public void setQueueCount(int? queueCount) {
     this.queueCount = queueCount;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }


  // Path("contactsharegroup")
  [XmlRoot("results")]
  public class ContactShareGroupList : BaseApiListBean<ContactShareGroup> {
    [XmlElement("contactShareGroups")]
    [XmlElement("contactShareGroup")]
   
    public override List<ContactShareGroup>? GetItems() => items;

    public override void SetItems(List<ContactShareGroup>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<ContactShareGroup>? items)
    {
        this.items = items;
    }
  }
}

}