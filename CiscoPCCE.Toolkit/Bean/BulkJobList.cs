using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("bulkjob")
[XmlRoot("results")]
public class BulkJobList : BaseApiBean {
  private List<BulkJob>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("bulkJobs")]
  [XmlElement("bulkJob")]
  public List<BulkJob>? Items
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


  // Path("bulkjob")
  [XmlRoot("results")]
  public class BulkJobListList : BaseApiListBean<BulkJobList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<BulkJobList>? GetItems() => items;

    public override void SetItems(List<BulkJobList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<BulkJobList>? items)
    {
        this.items = items;
    }
  }
}

}