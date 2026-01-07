using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("transferablefiles")
[XmlRoot("results")]
public class IVRApplicationList : BaseApiBean {
  private List<IVRApplication>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("ivrapplications")]
  [XmlElement("ivrapplication")]
  public List<IVRApplication>? Items
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


  // Path("transferablefiles")
  [XmlRoot("results")]
  public class IVRApplicationListList : BaseApiListBean<IVRApplicationList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<IVRApplicationList>? GetItems() => items;

    public override void SetItems(List<IVRApplicationList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<IVRApplicationList>? items)
    {
        this.items = items;
    }
  }
}

}