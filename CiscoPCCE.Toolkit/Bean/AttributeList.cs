using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("attribute")
[XmlRoot("results")]
public class AttributeList : BaseApiBean {
  private List<AttributeBase>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("attributes")]
  [XmlElement("attribute")]
  public List<AttributeBase>? Items
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


  // Path("attribute")
  [XmlRoot("results")]
  public class AttributeListList : BaseApiListBean<AttributeList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<AttributeList>? GetItems() => items;

    public override void SetItems(List<AttributeList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<AttributeList>? items)
    {
        this.items = items;
    }
  }
}

}