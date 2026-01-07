using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("smartlicense")
[XmlRoot("results")]
public class SmartLicenseProductInfoList : BaseApiBean {
  private List<SmartLicenseProductInfo>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("smartlicenseproductsinfo")]
  [XmlElement("smartlicenseproductinfo")]
  public List<SmartLicenseProductInfo>? Items
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
  public class SmartLicenseProductInfoListList : BaseApiListBean<SmartLicenseProductInfoList> {    public override List<SmartLicenseProductInfoList>? GetItems() => items;

    public override void SetItems(List<SmartLicenseProductInfoList>? value) => items = value;

  }
}

}