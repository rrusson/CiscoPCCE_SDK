using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("sipservergroup")
[XmlRoot("sipServerGroup")]
public class SipServerGroup : BaseApiBean {
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private ReferenceBean datacenter;
  private bool? defaultGroup;
  private ReferenceBean department;
  private string? description;
  private List<SipServerElement>? elements;
  private string? idFromRefUrl;
  private string? name;
  private int? noOfElements;
  private string? refURL;
  private SipServerType type;

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

  public ReferenceBean Datacenter
  {
      get => datacenter;
      set => datacenter = value;
  }


  public void setDatacenter(ReferenceBean datacenter) {
     this.datacenter = datacenter;
  }

  public bool? DefaultGroup
  {
      get => defaultGroup;
      set => defaultGroup = value;
  }


  public void setDefaultGroup(Boolean defaultGroup) {
     this.defaultGroup = defaultGroup;
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

  [XmlElement("elements")]
  [XmlElement("element")]
  public List<SipServerElement>? Elements
  {
      get => elements;
      set => elements = value;
  }


  public void setElements(List<SipServerElement> elements) {
     this.elements = elements;
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

  public int? NoOfElements
  {
      get => noOfElements;
      set => noOfElements = value;
  }


  public void setNoOfElements(int? noOfElements) {
     this.noOfElements = noOfElements;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public SipServerType Type
  {
      get => type;
      set => type = value;
  }


  public void setType(SipServerType type) {
     this.type = type;
  }


  // Path("sipservergroup")
  [XmlRoot("results")]
  public class SipServerGroupList : BaseApiListBean<SipServerGroup> {
    [XmlElement("sipServerGroups")]
    [XmlElement("sipServerGroup")]
   
    public override List<SipServerGroup>? GetItems() => items;

    public override void SetItems(List<SipServerGroup>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<SipServerGroup>? items)
    {
        this.items = items;
    }
  }
}

}