using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("smartlicense")
[XmlRoot("results")]
public class SmartLicenseEntitlementList : BaseApiBean {
  private List<SmartLicenseEntitlement>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("smartlicenseentitlements")]
  [XmlElement("smartlicenseentitlement")]
  public List<SmartLicenseEntitlement>? Items
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
  public class SmartLicenseEntitlementListList : BaseApiListBean<SmartLicenseEntitlementList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<SmartLicenseEntitlementList>? GetItems() => items;

    public override void SetItems(List<SmartLicenseEntitlementList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<SmartLicenseEntitlementList>? items)
    {
        this.items = items;
    }
  }
}

}