using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("peripheral")
[XmlRoot("results")]
public class PeripheralList : BaseApiBean {
  private List<PeripheralWithRoutingClient>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("peripherals")]
  [XmlElement("peripheral")]
  public List<PeripheralWithRoutingClient>? Items
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


  // Path("peripheral")
  [XmlRoot("results")]
  public class PeripheralListList : BaseApiListBean<PeripheralList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<PeripheralList>? GetItems() => items;

    public override void SetItems(List<PeripheralList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<PeripheralList>? items)
    {
        this.items = items;
    }
  }
}

}