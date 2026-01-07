using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("contactcenterai")
[XmlRoot("globalConfig")]
public class GlobalConfig : BaseApiBean {
  private string? name;
  private string? value;

  public string? Name
  {
      get => name;
      set => name = value;
  }

  public string? Value
  {
      get => value;
      set => value = value;
  }

  // Path("contactcenterai")
  [XmlRoot("results")]
  public class GlobalConfigList : BaseApiListBean<GlobalConfig> {    public override List<GlobalConfig>? GetItems() => items;

    public override void SetItems(List<GlobalConfig>? value) => items = value;

  }
}

}