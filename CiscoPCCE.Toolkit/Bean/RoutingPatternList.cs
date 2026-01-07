using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("routingpattern")
[XmlRoot("results")]
public class RoutingPatternList : BaseApiBean {
  private List<RoutingPattern>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("routingPatterns")]
  [XmlElement("routingPattern")]
  public List<RoutingPattern>? Items
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


  // Path("routingpattern")
  [XmlRoot("results")]
  public class RoutingPatternListList : BaseApiListBean<RoutingPatternList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<RoutingPatternList>? GetItems() => items;

    public override void SetItems(List<RoutingPatternList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<RoutingPatternList>? items)
    {
        this.items = items;
    }
  }
}

}