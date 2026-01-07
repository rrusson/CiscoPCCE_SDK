using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("tracelevel")
[XmlRoot("results")]
public class TraceLevelsList : BaseApiBean {
  private PermissionInfo permissionInfo;
  private TraceLevels traceLevels;

  public PermissionInfo PermissionInfo
  {
      get => permissionInfo;
      set => permissionInfo = value;
  }

  [XmlElement("traceLevels")]
  public TraceLevels TraceLevels
  {
      get => traceLevels;
      set => traceLevels = value;
  }

  // Path("tracelevel")
  [XmlRoot("results")]
  public class TraceLevelsListList : BaseApiListBean<TraceLevelsList> {    public override List<TraceLevelsList>? GetItems() => items;

    public override void SetItems(List<TraceLevelsList>? value) => items = value;

  }
}

}