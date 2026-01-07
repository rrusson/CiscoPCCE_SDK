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


  public void setPermissionInfo(PermissionInfo permissionInfo) {
     this.permissionInfo = permissionInfo;
  }

  [XmlElement("traceLevels")]
  public TraceLevels TraceLevels
  {
      get => traceLevels;
      set => traceLevels = value;
  }


  public void setTraceLevels(TraceLevels traceLevels) {
     this.traceLevels = traceLevels;
  }


  // Path("tracelevel")
  [XmlRoot("results")]
  public class TraceLevelsListList : BaseApiListBean<TraceLevelsList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<TraceLevelsList>? GetItems() => items;

    public override void SetItems(List<TraceLevelsList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<TraceLevelsList>? items)
    {
        this.items = items;
    }
  }
}

}