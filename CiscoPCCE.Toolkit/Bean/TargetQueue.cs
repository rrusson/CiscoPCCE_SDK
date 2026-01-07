using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("contactsharequeue")
[XmlRoot("targetQueue")]
public class TargetQueue : BaseApiBean {
  private int? id;

  public int? Id
  {
      get => id;
      set => id = value;
  }


  public void setId(int? id) {
     this.id = id;
  }


  // Path("contactsharequeue")
  [XmlRoot("results")]
  public class TargetQueueList : BaseApiListBean<TargetQueue> {
    [XmlElement("targetQueues")]
    [XmlElement("targetQueue")]
   
    public override List<TargetQueue>? GetItems() => items;

    public override void SetItems(List<TargetQueue>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<TargetQueue>? items)
    {
        this.items = items;
    }
  }
}

}