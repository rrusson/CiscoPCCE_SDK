using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("enterpriseroute")
[XmlRoot("results")]
public class EnterpriseRouteList : BaseApiBean {
  private List<EnterpriseRoute>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("EnterpriseRoutes")]
  [XmlElement("EnterpriseRoute")]
  public List<EnterpriseRoute>? Items
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

  // Path("enterpriseroute")
  [XmlRoot("results")]
  public class EnterpriseRouteListList : BaseApiListBean<EnterpriseRouteList> {    public override List<EnterpriseRouteList>? GetItems() => items;

    public override void SetItems(List<EnterpriseRouteList>? value) => items = value;

  }
}

}