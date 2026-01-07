using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("calltype")
[XmlRoot("results")]
public class CallTypeList : BaseApiBean {
  private List<CallType>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("callTypes")]
  [XmlElement("callType")]
  public List<CallType>? Items
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


  // Path("calltype")
  [XmlRoot("results")]
  public class CallTypeListList : BaseApiListBean<CallTypeList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<CallTypeList>? GetItems() => items;

    public override void SetItems(List<CallTypeList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<CallTypeList>? items)
    {
        this.items = items;
    }
  }
}

}