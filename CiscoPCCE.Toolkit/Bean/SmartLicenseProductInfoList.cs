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
  public class SmartLicenseProductInfoListList : BaseApiListBean<SmartLicenseProductInfoList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<SmartLicenseProductInfoList>? GetItems() => items;

    public override void SetItems(List<SmartLicenseProductInfoList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<SmartLicenseProductInfoList>? items)
    {
        this.items = items;
    }
  }
}

}