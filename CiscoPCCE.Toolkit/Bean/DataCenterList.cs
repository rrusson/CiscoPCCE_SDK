using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("results")]
public class DataCenterList : BaseApiBean {
  private List<DataCenter12k>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("datacenters")]
  [XmlElement("datacenter")]
  public List<DataCenter12k>? Items
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