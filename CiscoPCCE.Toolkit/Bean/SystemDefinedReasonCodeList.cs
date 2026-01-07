using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("reasoncode")
[XmlRoot("systemDefinedReasonCodes")]
public class SystemDefinedReasonCodeList : BaseApiBean {
  private List<ReasonCode>? reasonCode;

  public List<ReasonCode>? ReasonCode
  {
      get => reasonCode;
      set => reasonCode = value;
  }


  public void setReasonCode(List<ReasonCode> reasonCode) {
     this.reasonCode = reasonCode;
  }


  // Path("reasoncode")
  [XmlRoot("results")]
  public class SystemDefinedReasonCodeListList : BaseApiListBean<SystemDefinedReasonCodeList> {
    [XmlElement("systemDefinedReasonCodess")]
    [XmlElement("systemDefinedReasonCodes")]
   
    public override List<SystemDefinedReasonCodeList>? GetItems() => items;

    public override void SetItems(List<SystemDefinedReasonCodeList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<SystemDefinedReasonCodeList>? items)
    {
        this.items = items;
    }
  }
}

}