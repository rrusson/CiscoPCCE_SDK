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

  public PermissionInfo PermissionInfo
  {
      get => permissionInfo;
      set => permissionInfo = value;
  }

  // Path("smartlicense")
  [XmlRoot("results")]
  public class SmartLicenseEntitlementListList : BaseApiListBean<SmartLicenseEntitlementList> {    public override List<SmartLicenseEntitlementList>? GetItems() => items;

    public override void SetItems(List<SmartLicenseEntitlementList>? value) => items = value;

  }
}

}