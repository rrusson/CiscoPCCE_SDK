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


  public void setPageInfo(PageInfo pageInfo) {
     this.pageInfo = pageInfo;
  }

  public PermissionInfo PermissionInfo
  {
      get => permissionInfo;
      set => permissionInfo = value;
  }


  public void setPermissionInfo(PermissionInfo permissionInfo) {
     this.permissionInfo = permissionInfo;
  }


  // Path("/department")
  [XmlRoot("results")]
  public class DepartmentListList : BaseApiListBean<DepartmentList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<DepartmentList>? GetItems() => items;

    public override void SetItems(List<DepartmentList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<DepartmentList>? items)
    {
        this.items = items;
    }
  }
}

}