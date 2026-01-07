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

  public PermissionInfo PermissionInfo
  {
      get => permissionInfo;
      set => permissionInfo = value;
  }

  // Path("masterscript")
  [XmlRoot("results")]
  public class MasterScriptListList : BaseApiListBean<MasterScriptList> {    public override List<MasterScriptList>? GetItems() => items;

    public override void SetItems(List<MasterScriptList>? value) => items = value;

  }
}

}