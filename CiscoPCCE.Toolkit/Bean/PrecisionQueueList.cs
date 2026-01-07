using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("precisionqueue")
[XmlRoot("results")]
public class PrecisionQueueList : BaseApiBean {
  private List<PrecisionQueue>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("precisionQueues")]
  [XmlElement("precisionQueue")]
  public List<PrecisionQueue>? Items
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


  // Path("precisionqueue")
  [XmlRoot("results")]
  public class PrecisionQueueListList : BaseApiListBean<PrecisionQueueList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<PrecisionQueueList>? GetItems() => items;

    public override void SetItems(List<PrecisionQueueList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<PrecisionQueueList>? items)
    {
        this.items = items;
    }
  }
}

}