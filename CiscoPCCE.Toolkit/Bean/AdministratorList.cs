using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("administrator")
[XmlRoot("results")]
public class AdministratorList : BaseApiBean {
  private List<Administrator>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("administrators")]
  [XmlElement("administrator")]
  public List<Administrator>? Items
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


  // Path("administrator")
  [XmlRoot("results")]
  public class AdministratorListList : BaseApiListBean<AdministratorList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<AdministratorList>? GetItems() => items;

    public override void SetItems(List<AdministratorList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<AdministratorList>? items)
    {
        this.items = items;
    }
  }
}

}