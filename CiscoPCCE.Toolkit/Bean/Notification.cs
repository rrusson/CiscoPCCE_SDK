using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("notifications")
[XmlRoot("##default")]
public class Notification : BaseApiBean {
  private Category category;
  private int count;

  public Category Category
  {
      get => category;
      set => category = value;
  }

  public int Count
  {
      get => count;
      set => count = value;
  }

  // Path("notifications")
  [XmlRoot("results")]
  public class NotificationList : BaseApiListBean<Notification> {    public override List<Notification>? GetItems() => items;

    public override void SetItems(List<Notification>? value) => items = value;

  }
}

}