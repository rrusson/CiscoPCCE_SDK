using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("role")
[XmlRoot("results")]
public class RoleList : BaseApiBean {
  private List<Role>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("roles")]
  [XmlElement("role")]
  public List<Role>? Items
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


  // Path("role")
  [XmlRoot("results")]
  public class RoleListList : BaseApiListBean<RoleList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<RoleList>? GetItems() => items;

    public override void SetItems(List<RoleList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<RoleList>? items)
    {
        this.items = items;
    }
  }
}

}