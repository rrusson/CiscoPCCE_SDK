using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("transferablefiles")
[XmlRoot("results")]
public class IVRApplicationList : BaseApiBean {
  private List<IVRApplication>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("ivrapplications")]
  [XmlElement("ivrapplication")]
  public List<IVRApplication>? Items
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

  // Path("transferablefiles")
  [XmlRoot("results")]
  public class IVRApplicationListList : BaseApiListBean<IVRApplicationList> {    public override List<IVRApplicationList>? GetItems() => items;

    public override void SetItems(List<IVRApplicationList>? value) => items = value;

  }
}

}