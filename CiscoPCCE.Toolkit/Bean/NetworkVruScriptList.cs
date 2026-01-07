using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("networkvruscript")
[XmlRoot("results")]
public class NetworkVruScriptList : BaseApiBean {
  private List<NetworkVruScript>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("networkVruScripts")]
  [XmlElement("networkVruScript")]
  public List<NetworkVruScript>? Items
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

  // Path("networkvruscript")
  [XmlRoot("results")]
  public class NetworkVruScriptListList : BaseApiListBean<NetworkVruScriptList> {    public override List<NetworkVruScriptList>? GetItems() => items;

    public override void SetItems(List<NetworkVruScriptList>? value) => items = value;

  }
}

}