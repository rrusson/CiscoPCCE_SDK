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


  public void setName(String name) {
     this.name = name;
  }

  public bool? SystemDomain
  {
      get => systemDomain;
      set => systemDomain = value;
  }


  public void setSystemDomain(bool? systemDomain) {
     this.systemDomain = systemDomain;
  }


  // Path("activedirectorydomain")
  [XmlRoot("results")]
  public class ActiveDirectoryDomainList : BaseApiListBean<ActiveDirectoryDomain> {
    [XmlElement("activeDirectoryDomains")]
    [XmlElement("activeDirectoryDomain")]
   
    public override List<ActiveDirectoryDomain>? GetItems() => items;

    public override void SetItems(List<ActiveDirectoryDomain>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<ActiveDirectoryDomain>? items)
    {
        this.items = items;
    }
  }
}

}