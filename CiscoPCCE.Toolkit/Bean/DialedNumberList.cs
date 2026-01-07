using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("dialednumber")
[XmlRoot("results")]
public class DialedNumberList : BaseApiBean {
  private List<DialedNumber>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("dialedNumbers")]
  [XmlElement("dialedNumber")]
  public List<DialedNumber>? Items
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


  // Path("dialednumber")
  [XmlRoot("results")]
  public class DialedNumberListList : BaseApiListBean<DialedNumberList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<DialedNumberList>? GetItems() => items;

    public override void SetItems(List<DialedNumberList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<DialedNumberList>? items)
    {
        this.items = items;
    }
  }
}

}