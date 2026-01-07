using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("expandedcallvariable")
[XmlRoot("results")]
public class ExpandedCallVariableList : BaseApiBean {
  private ExpandedCallVariableGlobalInfo globalInfo;
  private List<ExpandedCallVariable>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  public ExpandedCallVariableGlobalInfo GlobalInfo
  {
      get => globalInfo;
      set => globalInfo = value;
  }

  [XmlElement("expandedCallVariables")]
  [XmlElement("expandedCallVariable")]
  public List<ExpandedCallVariable>? Items
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

  // Path("expandedcallvariable")
  [XmlRoot("results")]
  public class ExpandedCallVariableListList : BaseApiListBean<ExpandedCallVariableList> {    public override List<ExpandedCallVariableList>? GetItems() => items;

    public override void SetItems(List<ExpandedCallVariableList>? value) => items = value;

  }
}

}