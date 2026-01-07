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

  // Path("machineinventory")
  [XmlRoot("results")]
  public class CVAConfigInfoList : BaseApiListBean<CVAConfigInfo> {    public override List<CVAConfigInfo>? GetItems() => items;

    public override void SetItems(List<CVAConfigInfo>? value) => items = value;

  }
}

}