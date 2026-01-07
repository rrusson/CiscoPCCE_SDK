using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("networkvru")
[XmlRoot("results")]
public class NetworkVruList : BaseApiBean {
  private List<NetworkVru>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("networkVrus")]
  [XmlElement("networkVru")]
  public List<NetworkVru>? Items
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


  // Path("networkvru")
  [XmlRoot("results")]
  public class NetworkVruListList : BaseApiListBean<NetworkVruList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<NetworkVruList>? GetItems() => items;

    public override void SetItems(List<NetworkVruList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<NetworkVruList>? items)
    {
        this.items = items;
    }
  }
}

}