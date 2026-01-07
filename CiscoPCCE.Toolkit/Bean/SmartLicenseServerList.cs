using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("smartlicense")
[XmlRoot("results")]
public class SmartLicenseServerList : BaseApiBean {
  private List<SmartLicenseServerInfo>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("smartlicenseserverinfos")]
  [XmlElement("smartlicenseserverinfo")]
  public List<SmartLicenseServerInfo>? Items
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


  // Path("smartlicense")
  [XmlRoot("results")]
  public class SmartLicenseServerListList : BaseApiListBean<SmartLicenseServerList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<SmartLicenseServerList>? GetItems() => items;

    public override void SetItems(List<SmartLicenseServerList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<SmartLicenseServerList>? items)
    {
        this.items = items;
    }
  }
}

}