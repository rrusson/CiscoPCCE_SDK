using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("database")
[XmlRoot("results")]
public class DatabaseList : BaseApiBean {
  private List<Database>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("databases")]
  [XmlElement("database")]
  public List<Database>? Items
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


  // Path("database")
  [XmlRoot("results")]
  public class DatabaseListList : BaseApiListBean<DatabaseList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<DatabaseList>? GetItems() => items;

    public override void SetItems(List<DatabaseList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<DatabaseList>? items)
    {
        this.items = items;
    }
  }
}

}