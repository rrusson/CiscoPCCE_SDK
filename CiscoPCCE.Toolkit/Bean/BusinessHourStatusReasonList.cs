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

  public PermissionInfo PermissionInfo
  {
      get => permissionInfo;
      set => permissionInfo = value;
  }

  // Path("businesshourstatusreason")
  [XmlRoot("results")]
  public class BusinessHourStatusReasonListList : BaseApiListBean<BusinessHourStatusReasonList> {    public override List<BusinessHourStatusReasonList>? GetItems() => items;

    public override void SetItems(List<BusinessHourStatusReasonList>? value) => items = value;

  }
}

}