using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("mediaroutingdomain")
[XmlRoot("results")]
public class MediaRoutingDomainList : BaseApiBean {
  private List<MediaRoutingDomain>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("mediaRoutingDomains")]
  [XmlElement("mediaRoutingDomain")]
  public List<MediaRoutingDomain>? Items
  {
      get => items;
      set => items = value;
  }

  public PageInfo PageInfo
  {
      get => pageInfo;
      set => pageInfo = value;
  }


  public void setPageInfo(PageInfo pageInfo) {
     this.pageInfo = pageInfo;
  }

  public PermissionInfo PermissionInfo
  {
      get => permissionInfo;
      set => permissionInfo = value;
  }


  public void setPermissionInfo(PermissionInfo permissionInfo) {
     this.permissionInfo = permissionInfo;
  }


  // Path("mediaroutingdomain")
  [XmlRoot("results")]
  public class MediaRoutingDomainListList : BaseApiListBean<MediaRoutingDomainList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<MediaRoutingDomainList>? GetItems() => items;

    public override void SetItems(List<MediaRoutingDomainList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<MediaRoutingDomainList>? items)
    {
        this.items = items;
    }
  }
}

}