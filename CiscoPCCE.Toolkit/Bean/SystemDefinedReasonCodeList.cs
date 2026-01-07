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

  // Path("reasoncode")
  [XmlRoot("results")]
  public class SystemDefinedReasonCodeListList : BaseApiListBean<SystemDefinedReasonCodeList> {    public override List<SystemDefinedReasonCodeList>? GetItems() => items;

    public override void SetItems(List<SystemDefinedReasonCodeList>? value) => items = value;

  }
}

}