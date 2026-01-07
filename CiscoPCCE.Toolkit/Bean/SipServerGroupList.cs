using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("sipservergroup")
[XmlRoot("results")]
public class SipServerGroupList : BaseApiBean {
  private List<SipServerGroup>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("sipServerGroups")]
  [XmlElement("sipServerGroup")]
  public List<SipServerGroup>? Items
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


  // Path("sipservergroup")
  [XmlRoot("results")]
  public class SipServerGroupListList : BaseApiListBean<SipServerGroupList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<SipServerGroupList>? GetItems() => items;

    public override void SetItems(List<SipServerGroupList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<SipServerGroupList>? items)
    {
        this.items = items;
    }
  }
}

}