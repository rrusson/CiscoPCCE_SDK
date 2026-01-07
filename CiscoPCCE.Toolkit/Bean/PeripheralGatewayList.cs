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

  public PermissionInfo PermissionInfo
  {
      get => permissionInfo;
      set => permissionInfo = value;
  }

  // Path("secondaryaddress")
  [XmlRoot("results")]
  public class PeripheralGatewayListList : BaseApiListBean<PeripheralGatewayList> {    public override List<PeripheralGatewayList>? GetItems() => items;

    public override void SetItems(List<PeripheralGatewayList>? value) => items = value;

  }
}

}