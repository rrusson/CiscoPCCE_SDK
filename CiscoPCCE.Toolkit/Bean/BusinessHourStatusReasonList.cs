using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("businesshourstatusreason")
[XmlRoot("results")]
public class BusinessHourStatusReasonList : BaseApiBean {
  private List<BusinessHourStatusReason>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("businessHourStatusReasons")]
  [XmlElement("businessHourStatusReason")]
  public List<BusinessHourStatusReason>? Items
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


  // Path("businesshourstatusreason")
  [XmlRoot("results")]
  public class BusinessHourStatusReasonListList : BaseApiListBean<BusinessHourStatusReasonList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<BusinessHourStatusReasonList>? GetItems() => items;

    public override void SetItems(List<BusinessHourStatusReasonList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<BusinessHourStatusReasonList>? items)
    {
        this.items = items;
    }
  }
}

}