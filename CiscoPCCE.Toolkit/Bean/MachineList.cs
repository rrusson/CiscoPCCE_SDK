using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("machineinventory")
[XmlRoot("results")]
public class MachineList : BaseApiBean {
  private List<MachineHost>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("machines")]
  [XmlElement("machine")]
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
  public class MachineListList : BaseApiListBean<MachineList> {    public override List<MachineList>? GetItems() => items;

    public override void SetItems(List<MachineList>? value) => items = value;

  }
}

}