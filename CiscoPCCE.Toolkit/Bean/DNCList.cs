using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("dnc")
[XmlRoot("results")]
public class DNCList : BaseApiBean {
  private List<ImportRule>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("dncs")]
  [XmlElement("dnc")]
  public List<ImportRule>? Items
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


  // Path("dnc")
  [XmlRoot("results")]
  public class DNCListList : BaseApiListBean<DNCList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<DNCList>? GetItems() => items;

    public override void SetItems(List<DNCList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<DNCList>? items)
    {
        this.items = items;
    }
  }
}

}