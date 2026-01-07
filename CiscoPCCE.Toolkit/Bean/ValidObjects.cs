using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("validobjects")
[XmlRoot("validObjects")]
public class ValidObjects : BaseApiBean {
  private Access access;
  private List<int?>? ids;
  private string? type;

  public Access Access
  {
      get => access;
      set => access = value;
  }


  public void setAccess(Access access) {
     this.access = access;
  }

  public List<int?>? Ids
  {
      get => ids;
      set => ids = value;
  }


  public void setIds(List<int?> ids) {
     this.ids = ids;
  }

  public string? Type
  {
      get => type;
      set => type = value;
  }


  public void setType(String type) {
     this.type = type;
  }


  // Path("validobjects")
  [XmlRoot("results")]
  public class ValidObjectsList : BaseApiListBean<ValidObjects> {
    [XmlElement("validObjectss")]
    [XmlElement("validObjects")]
   
    public override List<ValidObjects>? GetItems() => items;

    public override void SetItems(List<ValidObjects>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<ValidObjects>? items)
    {
        this.items = items;
    }
  }
}

}