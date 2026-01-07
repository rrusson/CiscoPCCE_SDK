using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("/eccpayload")
[XmlRoot("results")]
public class ECCPayloadList : BaseApiBean {
  private List<ECCPayload>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("eccpayloads")]
  [XmlElement("eccpayload")]
  public List<ECCPayload>? Items
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


  // Path("/eccpayload")
  [XmlRoot("results")]
  public class ECCPayloadListList : BaseApiListBean<ECCPayloadList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<ECCPayloadList>? GetItems() => items;

    public override void SetItems(List<ECCPayloadList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<ECCPayloadList>? items)
    {
        this.items = items;
    }
  }
}

}