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

  public PermissionInfo PermissionInfo
  {
      get => permissionInfo;
      set => permissionInfo = value;
  }

  // Path("timezone")
  [XmlRoot("results")]
  public class TimeZoneLocationListList : BaseApiListBean<TimeZoneLocationList> {    public override List<TimeZoneLocationList>? GetItems() => items;

    public override void SetItems(List<TimeZoneLocationList>? value) => items = value;

  }
}

}