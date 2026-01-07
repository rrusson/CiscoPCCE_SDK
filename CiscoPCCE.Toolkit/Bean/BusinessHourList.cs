using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("businesshour")
[XmlRoot("results")]
public class BusinessHourList : BaseApiBean {
  private List<BusinessHour>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("businessHours")]
  [XmlElement("businessHour")]
  public List<BusinessHour>? Items
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


  // Path("businesshour")
  [XmlRoot("results")]
  public class BusinessHourListList : BaseApiListBean<BusinessHourList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<BusinessHourList>? GetItems() => items;

    public override void SetItems(List<BusinessHourList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<BusinessHourList>? items)
    {
        this.items = items;
    }
  }
}

}