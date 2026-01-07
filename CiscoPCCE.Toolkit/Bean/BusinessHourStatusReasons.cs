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


  public void setBusinessHourStatusReason(List<BusinessHourStatusReason> businessHourStatusReason) {
     this.businessHourStatusReason = businessHourStatusReason;
  }


  // Path("businesshourstatusreason")
  [XmlRoot("results")]
  public class BusinessHourStatusReasonsList : BaseApiListBean<BusinessHourStatusReasons> {
    [XmlElement("businessHourStatusReasonss")]
    [XmlElement("businessHourStatusReasons")]
   
    public override List<BusinessHourStatusReasons>? GetItems() => items;

    public override void SetItems(List<BusinessHourStatusReasons>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<BusinessHourStatusReasons>? items)
    {
        this.items = items;
    }
  }
}

}