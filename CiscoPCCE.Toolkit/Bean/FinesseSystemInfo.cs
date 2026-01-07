using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("status")
[XmlRoot("SystemInfo")]
public class FinesseSystemInfo : BaseApiBean {
  private string? status;

  [XmlElement("##default")]
  public string? Status
  {
      get => status;
      set => status = value;
  }


  public void setStatus(String status) {
     this.status = status;
  }


  // Path("status")
  [XmlRoot("results")]
  public class FinesseSystemInfoList : BaseApiListBean<FinesseSystemInfo> {
    [XmlElement("SystemInfos")]
    [XmlElement("SystemInfo")]
   
    public override List<FinesseSystemInfo>? GetItems() => items;

    public override void SetItems(List<FinesseSystemInfo>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<FinesseSystemInfo>? items)
    {
        this.items = items;
    }
  }
}

}