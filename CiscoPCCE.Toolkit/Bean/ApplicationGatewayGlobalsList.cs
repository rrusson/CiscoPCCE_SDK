using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("applicationgatewayglobalsetting")
[XmlRoot("results")]
public class ApplicationGatewayGlobalsList : BaseApiBean {
  private List<ApplicationGatewayGlobals>? items;
  private PermissionInfo permissionInfo;

  [XmlElement("applicationGatewayGlobalSettings")]
  [XmlElement("applicationGatewayGlobalSetting")]
  public List<ApplicationGatewayGlobals>? Items
  {
      get => items;
      set => items = value;
  }

  public PermissionInfo PermissionInfo
  {
      get => permissionInfo;
      set => permissionInfo = value;
  }

  // Path("applicationgatewayglobalsetting")
  [XmlRoot("results")]
  public class ApplicationGatewayGlobalsListList : BaseApiListBean<ApplicationGatewayGlobalsList> {    public override List<ApplicationGatewayGlobalsList>? GetItems() => items;

    public override void SetItems(List<ApplicationGatewayGlobalsList>? value) => items = value;

  }
}

}