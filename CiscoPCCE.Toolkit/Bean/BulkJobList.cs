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

  public PermissionInfo PermissionInfo
  {
      get => permissionInfo;
      set => permissionInfo = value;
  }

  // Path("bulkjob")
  [XmlRoot("results")]
  public class BulkJobListList : BaseApiListBean<BulkJobList> {    public override List<BulkJobList>? GetItems() => items;

    public override void SetItems(List<BulkJobList>? value) => items = value;

  }
}

}