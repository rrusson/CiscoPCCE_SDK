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


  public void setId(int? id) {
     this.id = id;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }


  public void setName(String name) {
     this.name = name;
  }


  // Path("contactsharequeue")
  [XmlRoot("results")]
  public class TargetInstanceRefList : BaseApiListBean<TargetInstanceRef> {
    [XmlElement("targetInstances")]
    [XmlElement("targetInstance")]
   
    public override List<TargetInstanceRef>? GetItems() => items;

    public override void SetItems(List<TargetInstanceRef>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<TargetInstanceRef>? items)
    {
        this.items = items;
    }
  }
}

}