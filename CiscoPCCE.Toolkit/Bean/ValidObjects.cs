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

  public List<int?>? Ids
  {
      get => ids;
      set => ids = value;
  }

  public string? Type
  {
      get => type;
      set => type = value;
  }

  // Path("validobjects")
  [XmlRoot("results")]
  public class ValidObjectsList : BaseApiListBean<ValidObjects> {    public override List<ValidObjects>? GetItems() => items;

    public override void SetItems(List<ValidObjects>? value) => items = value;

  }
}

}