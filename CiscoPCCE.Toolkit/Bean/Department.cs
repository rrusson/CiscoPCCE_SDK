using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("/department")
[XmlRoot("department")]
public class Department : BaseApiBean {
  private List<ReferenceBean>? administrators;
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private ReferenceBean department;
  private string? description;
  private string? idFromRefUrl;
  private bool? markDeletable;
  private string? name;
  private string? refURL;

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

  public ReferenceBean DepartmentRef
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

  // Path("/department")
  [XmlRoot("results")]
  public class DepartmentList : BaseApiListBean<Department> {    public override List<Department>? GetItems() => items;

    public override void SetItems(List<Department>? value) => items = value;

  }
}

}