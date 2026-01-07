using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("networkvru")
[XmlRoot("results")]
public class NetworkVruList : BaseApiBean {
  private List<NetworkVru>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("networkVrus")]
  [XmlElement("networkVru")]
  public List<NetworkVru>? Items
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

  // Path("networkvru")
  [XmlRoot("results")]
  public class NetworkVruListList : BaseApiListBean<NetworkVruList> {    public override List<NetworkVruList>? GetItems() => items;

    public override void SetItems(List<NetworkVruList>? value) => items = value;

  }
}

}