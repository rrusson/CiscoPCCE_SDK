using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("applicationpath")
[XmlRoot("results")]
public class ApplicationPathList : BaseApiBean {
  private List<ApplicationPath>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("applicationPaths")]
  [XmlElement("applicationPath")]
  public List<ApplicationPath>? Items
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


  // Path("applicationpath")
  [XmlRoot("results")]
  public class ApplicationPathListList : BaseApiListBean<ApplicationPathList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<ApplicationPathList>? GetItems() => items;

    public override void SetItems(List<ApplicationPathList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<ApplicationPathList>? items)
    {
        this.items = items;
    }
  }
}

}