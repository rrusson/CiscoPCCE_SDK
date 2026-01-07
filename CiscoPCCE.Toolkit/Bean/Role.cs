using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("role")
[XmlRoot("role")]
public class Role : BaseApiBean {
  private List<ReferenceBean>? administrators;
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private ReferenceBean department;
  private string? description;
  private List<Feature>? features;
  private string? idFromRefUrl;
  private string? name;
  private string? refURL;
  private bool? systemDefined;

  [XmlElement("administrators")]
  [XmlElement("administrator")]
  public List<ReferenceBean>? Administrators
  {
      get => administrators;
      set => administrators = value;
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

  [XmlElement("accessList")]
  [XmlElement("feature")]
  public List<Feature>? Features
  {
      get => features;
      set => features = value;
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

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  public bool? SystemDefined
  {
      get => systemDefined;
      set => systemDefined = value;
  }

  // Path("role")
  [XmlRoot("results")]
  public class RoleList : BaseApiListBean<Role> {    public override List<Role>? GetItems() => items;

    public override void SetItems(List<Role>? value) => items = value;

  }
}

}