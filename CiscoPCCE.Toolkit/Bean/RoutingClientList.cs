using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("secondaryaddress")
[XmlRoot("results")]
public class RoutingClientList : BaseApiBean {
  private List<RoutingClient>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("routingClients")]
  [XmlElement("routingClient")]
  public List<RoutingClient>? Items
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
  public class RoutingClientListList : BaseApiListBean<RoutingClientList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<RoutingClientList>? GetItems() => items;

    public override void SetItems(List<RoutingClientList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<RoutingClientList>? items)
    {
        this.items = items;
    }
  }
}

}