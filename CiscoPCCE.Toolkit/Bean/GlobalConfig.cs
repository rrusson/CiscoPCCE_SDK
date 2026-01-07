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


  public void setName(String name) {
     this.name = name;
  }

  public string? Value
  {
      get => value;
      set => value = value;
  }


  public void setValue(String value) {
     this.value = value;
  }


  // Path("contactcenterai")
  [XmlRoot("results")]
  public class GlobalConfigList : BaseApiListBean<GlobalConfig> {
    [XmlElement("globalConfigs")]
    [XmlElement("globalConfig")]
   
    public override List<GlobalConfig>? GetItems() => items;

    public override void SetItems(List<GlobalConfig>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<GlobalConfig>? items)
    {
        this.items = items;
    }
  }
}

}