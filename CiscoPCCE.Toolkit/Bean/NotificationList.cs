using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("notifications")
[XmlRoot("results")]
public class NotificationList : BaseApiBean {
  private PermissionInfo permissionInfo;

  public PermissionInfo PermissionInfo
  {
      get => permissionInfo;
      set => permissionInfo = value;
  }


  public void setPermissionInfo(PermissionInfo permissionInfo) {
     this.permissionInfo = permissionInfo;
  }


  // Path("notifications")
  [XmlRoot("results")]
  public class NotificationListList : BaseApiListBean<NotificationList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<NotificationList>? GetItems() => items;

    public override void SetItems(List<NotificationList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<NotificationList>? items)
    {
        this.items = items;
    }
  }
}

}