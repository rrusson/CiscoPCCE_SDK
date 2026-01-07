using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("contactsharequeue")
[XmlRoot("results")]
public class ContactShareQueueList : BaseApiBean {
  private List<ContactShareQueue>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("contactShareQueues")]
  [XmlElement("contactShareQueue")]
  public List<ContactShareQueue>? Items
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


  // Path("contactsharequeue")
  [XmlRoot("results")]
  public class ContactShareQueueListList : BaseApiListBean<ContactShareQueueList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<ContactShareQueueList>? GetItems() => items;

    public override void SetItems(List<ContactShareQueueList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<ContactShareQueueList>? items)
    {
        this.items = items;
    }
  }
}

}