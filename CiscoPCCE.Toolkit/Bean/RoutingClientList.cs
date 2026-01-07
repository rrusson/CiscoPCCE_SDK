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

  public PermissionInfo PermissionInfo
  {
      get => permissionInfo;
      set => permissionInfo = value;
  }

  // Path("secondaryaddress")
  [XmlRoot("results")]
  public class RoutingClientListList : BaseApiListBean<RoutingClientList> {    public override List<RoutingClientList>? GetItems() => items;

    public override void SetItems(List<RoutingClientList>? value) => items = value;

  }
}

}