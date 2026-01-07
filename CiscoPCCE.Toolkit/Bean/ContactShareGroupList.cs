using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("contactsharegroup")
[XmlRoot("results")]
public class ContactShareGroupList : BaseApiBean {
  private List<ContactShareGroup>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("contactShareGroups")]
  [XmlElement("contactShareGroup")]
  public List<ContactShareGroup>? Items
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


  // Path("contactsharegroup")
  [XmlRoot("results")]
  public class ContactShareGroupListList : BaseApiListBean<ContactShareGroupList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<ContactShareGroupList>? GetItems() => items;

    public override void SetItems(List<ContactShareGroupList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<ContactShareGroupList>? items)
    {
        this.items = items;
    }
  }
}

}