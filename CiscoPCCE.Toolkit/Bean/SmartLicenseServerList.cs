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

  public PermissionInfo PermissionInfo
  {
      get => permissionInfo;
      set => permissionInfo = value;
  }

  // Path("smartlicense")
  [XmlRoot("results")]
  public class SmartLicenseServerListList : BaseApiListBean<SmartLicenseServerList> {    public override List<SmartLicenseServerList>? GetItems() => items;

    public override void SetItems(List<SmartLicenseServerList>? value) => items = value;

  }
}

}