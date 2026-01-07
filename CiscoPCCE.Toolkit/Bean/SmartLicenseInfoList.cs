using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("smartlicense")
[XmlRoot("results")]
public class SmartLicenseInfoList : BaseApiBean {
  private List<SmartLicenseInfo>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("smartlicenseinfos")]
  [XmlElement("smartlicenseinfo")]
  public List<SmartLicenseInfo>? Items
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
  public class SmartLicenseInfoListList : BaseApiListBean<SmartLicenseInfoList> {    public override List<SmartLicenseInfoList>? GetItems() => items;

    public override void SetItems(List<SmartLicenseInfoList>? value) => items = value;

  }
}

}