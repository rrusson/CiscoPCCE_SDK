using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("applicationpath")
[XmlRoot("applicationPath")]
public class ApplicationPath : BaseApiBean {
  private ReferenceBean applicationInstance;
  private List<ApplicationPathMember>? applicationPathMembers;
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private ReferenceBean department;
  private string? description;
  private string? idFromRefUrl;
  private int? logicalControllerId;
  private string? name;
  private string? refURL;

  public ReferenceBean ApplicationInstance
  {
      get => applicationInstance;
      set => applicationInstance = value;
  }


  public void setApplicationInstance(ReferenceBean applicationInstance) {
     this.applicationInstance = applicationInstance;
  }

  [XmlElement("applicationPathMembers")]
  [XmlElement("applicationPathMember")]
  public List<ApplicationPathMember>? ApplicationPathMembers
  {
      get => applicationPathMembers;
      set => applicationPathMembers = value;
  }


  public void setApplicationPathMembers(List<ApplicationPathMember> applicationPathMembers) {
     this.applicationPathMembers = applicationPathMembers;
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

  public int? LogicalControllerId
  {
      get => logicalControllerId;
      set => logicalControllerId = value;
  }


  public void setLogicalControllerId(int? logicalControllerId) {
     this.logicalControllerId = logicalControllerId;
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


  // Path("applicationpath")
  [XmlRoot("results")]
  public class ApplicationPathList : BaseApiListBean<ApplicationPath> {
    [XmlElement("applicationPaths")]
    [XmlElement("applicationPath")]
   
    public override List<ApplicationPath>? GetItems() => items;

    public override void SetItems(List<ApplicationPath>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<ApplicationPath>? items)
    {
        this.items = items;
    }
  }
}

}