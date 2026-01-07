using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("machineinventory")
[XmlRoot("results")]
public class MachineHostList : BaseApiBean {
  private List<MachineHost>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("hosts")]
  [XmlElement("host")]
  public List<MachineHost>? Items
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

  // Path("machineinventory")
  [XmlRoot("results")]
  public class MachineHostListList : BaseApiListBean<MachineHostList> {    public override List<MachineHostList>? GetItems() => items;

    public override void SetItems(List<MachineHostList>? value) => items = value;

  }
}

}