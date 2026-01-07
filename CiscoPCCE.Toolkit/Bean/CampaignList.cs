using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("campaign")
[XmlRoot("results")]
public class CampaignList : BaseApiBean {
  private List<Campaign>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("campaigns")]
  [XmlElement("campaign")]
  public List<Campaign>? Items
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


  // Path("campaign")
  [XmlRoot("results")]
  public class CampaignListList : BaseApiListBean<CampaignList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<CampaignList>? GetItems() => items;

    public override void SetItems(List<CampaignList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<CampaignList>? items)
    {
        this.items = items;
    }
  }
}

}