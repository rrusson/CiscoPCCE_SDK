using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("timezone")
[XmlRoot("results")]
public class TimeZoneList : BaseApiBean {
  private List<TimeZone>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("timeZones")]
  [XmlElement("timeZone")]
  public List<TimeZone>? Items
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


  // Path("timezone")
  [XmlRoot("results")]
  public class TimeZoneListList : BaseApiListBean<TimeZoneList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<TimeZoneList>? GetItems() => items;

    public override void SetItems(List<TimeZoneList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<TimeZoneList>? items)
    {
        this.items = items;
    }
  }
}

}