using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("/department")
[XmlRoot("results")]
public class DepartmentList : BaseApiBean {
  private List<Department>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("departments")]
  [XmlElement("department")]
  public List<Department>? Items
  {
      get => items;
      set => items = value;
  }

  public PageInfo PageInfo
  {
      get => pageInfo;
      set => pageInfo = value;
  }

  public PermissionInfo PermissionInfo
  {
      get => permissionInfo;
      set => permissionInfo = value;
  }

  // Path("/department")
  [XmlRoot("results")]
  public class DepartmentListList : BaseApiListBean<DepartmentList> {    public override List<DepartmentList>? GetItems() => items;

    public override void SetItems(List<DepartmentList>? value) => items = value;

  }
}

}