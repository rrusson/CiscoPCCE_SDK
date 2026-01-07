using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("calltype")
[XmlRoot("results")]
public class CallTypeList : BaseApiBean {
  private List<CallType>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("callTypes")]
  [XmlElement("callType")]
  public List<CallType>? Items
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

  // Path("calltype")
  [XmlRoot("results")]
  public class CallTypeListList : BaseApiListBean<CallTypeList> {    public override List<CallTypeList>? GetItems() => items;

    public override void SetItems(List<CallTypeList>? value) => items = value;

  }
}

}