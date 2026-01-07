using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





public class DatacenterRoutingTypeBeanList : BaseApiBean {
  private List<DatacenterRoutingTypeBean>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("datacenterRoutingType")]
  public List<DatacenterRoutingTypeBean>? Items
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