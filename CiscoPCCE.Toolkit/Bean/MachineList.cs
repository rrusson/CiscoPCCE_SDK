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


  public void setPageInfo(PageInfo pageInfo) {
     this.pageInfo = pageInfo;
  }

  public PermissionInfo PermissionInfo
  {
      get => permissionInfo;
      set => permissionInfo = value;
  }


  public void setPermissionInfo(PermissionInfo permissionInfo) {
     this.permissionInfo = permissionInfo;
  }


  // Path("machineinventory")
  [XmlRoot("results")]
  public class MachineListList : BaseApiListBean<MachineList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<MachineList>? GetItems() => items;

    public override void SetItems(List<MachineList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<MachineList>? items)
    {
        this.items = items;
    }
  }
}

}