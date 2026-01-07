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
  public class SmartLicenseInfoListList : BaseApiListBean<SmartLicenseInfoList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<SmartLicenseInfoList>? GetItems() => items;

    public override void SetItems(List<SmartLicenseInfoList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<SmartLicenseInfoList>? items)
    {
        this.items = items;
    }
  }
}

}