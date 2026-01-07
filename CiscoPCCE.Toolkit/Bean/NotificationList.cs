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

  // Path("notifications")
  [XmlRoot("results")]
  public class NotificationListList : BaseApiListBean<NotificationList> {    public override List<NotificationList>? GetItems() => items;

    public override void SetItems(List<NotificationList>? value) => items = value;

  }
}

}