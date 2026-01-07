using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("reasoncode")
[XmlRoot("results")]
public class ReasonCodeList : BaseApiBean {
  private List<ReasonCode>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("reasonCodes")]
  [XmlElement("reasonCode")]
  public List<ReasonCode>? Items
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

  // Path("reasoncode")
  [XmlRoot("results")]
  public class ReasonCodeListList : BaseApiListBean<ReasonCodeList> {    public override List<ReasonCodeList>? GetItems() => items;

    public override void SetItems(List<ReasonCodeList>? value) => items = value;

  }
}

}