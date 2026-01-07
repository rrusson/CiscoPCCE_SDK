using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("activedirectorydomain")
[XmlRoot("results")]
public class ActiveDirectoryDomainList : BaseApiBean {


  // Path("activedirectorydomain")
  [XmlRoot("results")]
  public class ActiveDirectoryDomainListList : BaseApiListBean<ActiveDirectoryDomainList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<ActiveDirectoryDomainList>? GetItems() => items;

    public override void SetItems(List<ActiveDirectoryDomainList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<ActiveDirectoryDomainList>? items)
    {
        this.items = items;
    }
  }
}

}