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

  // Path("contactsharequeue")
  [XmlRoot("results")]
  public class TargetQueueList : BaseApiListBean<TargetQueue> {    public override List<TargetQueue>? GetItems() => items;

    public override void SetItems(List<TargetQueue>? value) => items = value;

  }
}

}