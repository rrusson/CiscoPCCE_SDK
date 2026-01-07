using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("logcollection")
[XmlRoot("results")]
public class LogCollectionList : BaseApiBean {
  private PermissionInfo permissionInfo;

  public PermissionInfo PermissionInfo
  {
      get => permissionInfo;
      set => permissionInfo = value;
  }

  // Path("logcollection")
  [XmlRoot("results")]
  public class LogCollectionListList : BaseApiListBean<LogCollectionList> {    public override List<LogCollectionList>? GetItems() => items;

    public override void SetItems(List<LogCollectionList>? value) => items = value;

  }
}

}