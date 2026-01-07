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


  public void setPermissionInfo(PermissionInfo permissionInfo) {
     this.permissionInfo = permissionInfo;
  }


  // Path("logcollection")
  [XmlRoot("results")]
  public class LogCollectionListList : BaseApiListBean<LogCollectionList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<LogCollectionList>? GetItems() => items;

    public override void SetItems(List<LogCollectionList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<LogCollectionList>? items)
    {
        this.items = items;
    }
  }
}

}