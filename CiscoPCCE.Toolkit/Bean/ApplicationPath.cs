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

  [XmlElement("applicationPathMembers")]
  [XmlElement("applicationPathMember")]
  public List<ApplicationPathMember>? ApplicationPathMembers
  {
      get => applicationPathMembers;
      set => applicationPathMembers = value;
  }

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

  public int? LogicalControllerId
  {
      get => logicalControllerId;
      set => logicalControllerId = value;
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

  // Path("applicationpath")
  [XmlRoot("results")]
  public class ApplicationPathList : BaseApiListBean<ApplicationPath> {    public override List<ApplicationPath>? GetItems() => items;

    public override void SetItems(List<ApplicationPath>? value) => items = value;

  }
}

}