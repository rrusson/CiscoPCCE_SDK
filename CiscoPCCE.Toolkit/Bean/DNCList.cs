using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("dnc")
[XmlRoot("results")]
public class DNCList : BaseApiBean {
  private List<ImportRule>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("dncs")]
  [XmlElement("dnc")]
  public List<ImportRule>? Items
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

  // Path("dnc")
  [XmlRoot("results")]
  public class DNCListList : BaseApiListBean<DNCList> {    public override List<DNCList>? GetItems() => items;

    public override void SetItems(List<DNCList>? value) => items = value;

  }
}

}