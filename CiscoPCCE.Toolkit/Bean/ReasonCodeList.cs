using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("reasoncode")
[XmlRoot("results")]
public class ReasonCodeList : BaseApiBean {
  private List<ReasonCode>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("reasonCodes")]
  [XmlElement("reasonCode")]
  public List<ReasonCode>? Items
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


  // Path("reasoncode")
  [XmlRoot("results")]
  public class ReasonCodeListList : BaseApiListBean<ReasonCodeList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<ReasonCodeList>? GetItems() => items;

    public override void SetItems(List<ReasonCodeList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<ReasonCodeList>? items)
    {
        this.items = items;
    }
  }
}

}