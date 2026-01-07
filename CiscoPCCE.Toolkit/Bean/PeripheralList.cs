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

  public PermissionInfo PermissionInfo
  {
      get => permissionInfo;
      set => permissionInfo = value;
  }

  // Path("peripheral")
  [XmlRoot("results")]
  public class PeripheralListList : BaseApiListBean<PeripheralList> {    public override List<PeripheralList>? GetItems() => items;

    public override void SetItems(List<PeripheralList>? value) => items = value;

  }
}

}