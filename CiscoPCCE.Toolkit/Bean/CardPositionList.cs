using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("layout")
[XmlRoot("layout")]
public class CardPositionList : BaseApiBean {
  private List<CardPosition>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("cards")]
  [XmlElement("card")]
  public List<CardPosition>? Items
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


  // Path("layout")
  [XmlRoot("results")]
  public class CardPositionListList : BaseApiListBean<CardPositionList> {
    [XmlElement("layouts")]
    [XmlElement("layout")]
   
    public override List<CardPositionList>? GetItems() => items;

    public override void SetItems(List<CardPositionList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<CardPositionList>? items)
    {
        this.items = items;
    }
  }
}

}