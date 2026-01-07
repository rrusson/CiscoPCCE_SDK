using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("timezone")
[XmlRoot("results")]
public class TimeZoneLocationList : BaseApiBean {
  private List<TimeZoneLocation>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("timeZones")]
  [XmlElement("timeZone")]
  public List<TimeZoneLocation>? Items
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
  public class TimeZoneLocationListList : BaseApiListBean<TimeZoneLocationList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<TimeZoneLocationList>? GetItems() => items;

    public override void SetItems(List<TimeZoneLocationList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<TimeZoneLocationList>? items)
    {
        this.items = items;
    }
  }
}

}