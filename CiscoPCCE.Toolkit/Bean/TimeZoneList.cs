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

  public PermissionInfo PermissionInfo
  {
      get => permissionInfo;
      set => permissionInfo = value;
  }

  // Path("timezone")
  [XmlRoot("results")]
  public class TimeZoneListList : BaseApiListBean<TimeZoneList> {    public override List<TimeZoneList>? GetItems() => items;

    public override void SetItems(List<TimeZoneList>? value) => items = value;

  }
}

}