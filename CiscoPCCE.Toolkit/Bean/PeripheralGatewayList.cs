using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("secondaryaddress")
[XmlRoot("results")]
public class PeripheralGatewayList : BaseApiBean {
  private List<PeripheralGateway>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("peripheralGateways")]
  [XmlElement("peripheralGateway")]
  public List<PeripheralGateway>? Items
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


  // Path("secondaryaddress")
  [XmlRoot("results")]
  public class PeripheralGatewayListList : BaseApiListBean<PeripheralGatewayList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<PeripheralGatewayList>? GetItems() => items;

    public override void SetItems(List<PeripheralGatewayList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<PeripheralGatewayList>? items)
    {
        this.items = items;
    }
  }
}

}