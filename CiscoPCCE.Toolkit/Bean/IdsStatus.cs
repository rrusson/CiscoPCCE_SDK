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


  public void setState(String state) {
     this.state = state;
  }


  // Path("sso")
  [XmlRoot("results")]
  public class IdsStatusList : BaseApiListBean<IdsStatus> {
    [XmlElement("idsStatuss")]
    [XmlElement("idsStatus")]
   
    public override List<IdsStatus>? GetItems() => items;

    public override void SetItems(List<IdsStatus>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<IdsStatus>? items)
    {
        this.items = items;
    }
  }
}

}