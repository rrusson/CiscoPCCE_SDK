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

  public PermissionInfo PermissionInfo
  {
      get => permissionInfo;
      set => permissionInfo = value;
  }

  // Path("layout")
  [XmlRoot("results")]
  public class CardPositionListList : BaseApiListBean<CardPositionList> {    public override List<CardPositionList>? GetItems() => items;

    public override void SetItems(List<CardPositionList>? value) => items = value;

  }
}

}