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

  public PermissionInfo PermissionInfo
  {
      get => permissionInfo;
      set => permissionInfo = value;
  }

  // Path("mediaroutingdomain")
  [XmlRoot("results")]
  public class MediaRoutingDomainListList : BaseApiListBean<MediaRoutingDomainList> {    public override List<MediaRoutingDomainList>? GetItems() => items;

    public override void SetItems(List<MediaRoutingDomainList>? value) => items = value;

  }
}

}