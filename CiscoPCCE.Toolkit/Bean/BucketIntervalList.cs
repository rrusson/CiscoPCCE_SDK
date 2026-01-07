using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("bucketinterval")
[XmlRoot("results")]
public class BucketIntervalList : BaseApiBean {
  private List<BucketInterval>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("bucketIntervals")]
  [XmlElement("bucketInterval")]
  public List<BucketInterval>? Items
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


  // Path("bucketinterval")
  [XmlRoot("results")]
  public class BucketIntervalListList : BaseApiListBean<BucketIntervalList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<BucketIntervalList>? GetItems() => items;

    public override void SetItems(List<BucketIntervalList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<BucketIntervalList>? items)
    {
        this.items = items;
    }
  }
}

}