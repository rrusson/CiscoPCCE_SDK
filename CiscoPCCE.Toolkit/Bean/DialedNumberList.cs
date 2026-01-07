using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("dialednumber")
[XmlRoot("results")]
public class DialedNumberList : BaseApiBean {
  private List<DialedNumber>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("dialedNumbers")]
  [XmlElement("dialedNumber")]
  public List<DialedNumber>? Items
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

  // Path("dialednumber")
  [XmlRoot("results")]
  public class DialedNumberListList : BaseApiListBean<DialedNumberList> {    public override List<DialedNumberList>? GetItems() => items;

    public override void SetItems(List<DialedNumberList>? value) => items = value;

  }
}

}