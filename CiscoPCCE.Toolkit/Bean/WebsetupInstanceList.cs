using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("instance")
[XmlRoot("results")]
public class WebsetupInstanceList : BaseApiBean {


  // Path("instance")
  [XmlRoot("results")]
  public class WebsetupInstanceListList : BaseApiListBean<WebsetupInstanceList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<WebsetupInstanceList>? GetItems() => items;

    public override void SetItems(List<WebsetupInstanceList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<WebsetupInstanceList>? items)
    {
        this.items = items;
    }
  }
}

}