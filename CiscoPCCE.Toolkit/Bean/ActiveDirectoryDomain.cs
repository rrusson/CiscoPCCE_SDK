using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("activedirectorydomain")
[XmlRoot("activeDirectoryDomain")]
public class ActiveDirectoryDomain : BaseApiBean {
  private string? name;
  private bool? systemDomain;

  public string? Name
  {
      get => name;
      set => name = value;
  }

  public bool? SystemDomain
  {
      get => systemDomain;
      set => systemDomain = value;
  }

  // Path("activedirectorydomain")
  [XmlRoot("results")]
  public class ActiveDirectoryDomainList : BaseApiListBean<ActiveDirectoryDomain> {    public override List<ActiveDirectoryDomain>? GetItems() => items;

    public override void SetItems(List<ActiveDirectoryDomain>? value) => items = value;

  }
}

}