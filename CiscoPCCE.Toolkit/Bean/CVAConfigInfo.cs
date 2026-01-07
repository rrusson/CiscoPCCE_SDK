using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("machineinventory")
[XmlRoot("speechConfig")]
public class CVAConfigInfo : BaseApiBean {
  private string? version;

  [XmlElement("version")]
  public string? Version
  {
      get => version;
      set => version = value;
  }


  public void setVersion(String version) {
     this.version = version;
  }


  // Path("machineinventory")
  [XmlRoot("results")]
  public class CVAConfigInfoList : BaseApiListBean<CVAConfigInfo> {
    [XmlElement("speechConfigs")]
    [XmlElement("speechConfig")]
   
    public override List<CVAConfigInfo>? GetItems() => items;

    public override void SetItems(List<CVAConfigInfo>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<CVAConfigInfo>? items)
    {
        this.items = items;
    }
  }
}

}