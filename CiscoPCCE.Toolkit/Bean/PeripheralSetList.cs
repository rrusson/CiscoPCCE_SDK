using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("results")]
public class PeripheralSetList : BaseApiBean {
  private List<PeripheralSet>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("peripheralSets")]
  [XmlElement("peripheralSet")]
  public List<PeripheralSet>? Items
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


}

}