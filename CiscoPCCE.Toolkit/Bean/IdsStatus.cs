using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("sso")
[XmlRoot("idsStatus")]
public class IdsStatus : BaseApiBean {
  private string? state;

  public string? State
  {
      get => state;
      set => state = value;
  }

  // Path("sso")
  [XmlRoot("results")]
  public class IdsStatusList : BaseApiListBean<IdsStatus> {    public override List<IdsStatus>? GetItems() => items;

    public override void SetItems(List<IdsStatus>? value) => items = value;

  }
}

}