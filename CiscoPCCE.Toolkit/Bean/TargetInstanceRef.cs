using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("contactsharequeue")
[XmlRoot("targetInstance")]
public class TargetInstanceRef : BaseApiBean {
  private int? id;
  private string? name;

  public int? Id
  {
      get => id;
      set => id = value;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }

  // Path("contactsharequeue")
  [XmlRoot("results")]
  public class TargetInstanceRefList : BaseApiListBean<TargetInstanceRef> {    public override List<TargetInstanceRef>? GetItems() => items;

    public override void SetItems(List<TargetInstanceRef>? value) => items = value;

  }
}

}