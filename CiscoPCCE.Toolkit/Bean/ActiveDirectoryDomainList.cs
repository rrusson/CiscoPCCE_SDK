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
    public override List<ActiveDirectoryDomainList>? GetItems() => items;

    public override void SetItems(List<ActiveDirectoryDomainList>? value) => items = value;

  }
}

}