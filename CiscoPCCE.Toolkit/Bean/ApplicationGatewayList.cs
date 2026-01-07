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

  public PermissionInfo PermissionInfo
  {
      get => permissionInfo;
      set => permissionInfo = value;
  }

  // Path("applicationgateway")
  [XmlRoot("results")]
  public class ApplicationGatewayListList : BaseApiListBean<ApplicationGatewayList> {    public override List<ApplicationGatewayList>? GetItems() => items;

    public override void SetItems(List<ApplicationGatewayList>? value) => items = value;

  }
}

}