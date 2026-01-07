using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("masterscript")
[XmlRoot("results")]
public class MasterScriptList : BaseApiBean {
  private List<MasterScript>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("masterScripts")]
  [XmlElement("masterScript")]
  public List<MasterScript>? Items
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


  // Path("masterscript")
  [XmlRoot("results")]
  public class MasterScriptListList : BaseApiListBean<MasterScriptList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<MasterScriptList>? GetItems() => items;

    public override void SetItems(List<MasterScriptList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<MasterScriptList>? items)
    {
        this.items = items;
    }
  }
}

}