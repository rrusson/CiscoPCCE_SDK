using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("businesshourstatusreason")
[XmlRoot("businessHourStatusReasons")]
public class BusinessHourStatusReasons : BaseApiBean {
  private List<BusinessHourStatusReason>? businessHourStatusReason;

  public List<BusinessHourStatusReason>? BusinessHourStatusReason
  {
      get => businessHourStatusReason;
      set => businessHourStatusReason = value;
  }

  // Path("businesshourstatusreason")
  [XmlRoot("results")]
  public class BusinessHourStatusReasonsList : BaseApiListBean<BusinessHourStatusReasons> {    public override List<BusinessHourStatusReasons>? GetItems() => items;

    public override void SetItems(List<BusinessHourStatusReasons>? value) => items = value;

  }
}

}