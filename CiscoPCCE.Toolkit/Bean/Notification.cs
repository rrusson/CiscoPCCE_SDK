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


  public void setCategory(Category category) {
     this.category = category;
  }

  public int Count
  {
      get => count;
      set => count = value;
  }


  public void setCount(int count) {
     this.count = count;
  }


  // Path("notifications")
  [XmlRoot("results")]
  public class NotificationList : BaseApiListBean<Notification> {
    [XmlElement("##defaults")]
    [XmlElement("##default")]
   
    public override List<Notification>? GetItems() => items;

    public override void SetItems(List<Notification>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<Notification>? items)
    {
        this.items = items;
    }
  }
}

}