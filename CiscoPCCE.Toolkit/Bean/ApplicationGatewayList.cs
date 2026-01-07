using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("applicationgateway")
[XmlRoot("results")]
public class ApplicationGatewayList : BaseApiBean {
  private List<ApplicationGateway>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("applicationGateways")]
  [XmlElement("applicationGateway")]
  public List<ApplicationGateway>? Items
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


  // Path("applicationgateway")
  [XmlRoot("results")]
  public class ApplicationGatewayListList : BaseApiListBean<ApplicationGatewayList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<ApplicationGatewayList>? GetItems() => items;

    public override void SetItems(List<ApplicationGatewayList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<ApplicationGatewayList>? items)
    {
        this.items = items;
    }
  }
}

}