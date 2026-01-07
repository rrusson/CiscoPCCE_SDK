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


  public void setGlobalInfo(ExpandedCallVariableGlobalInfo globalInfo) {
     this.globalInfo = globalInfo;
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


  // Path("expandedcallvariable")
  [XmlRoot("results")]
  public class ExpandedCallVariableListList : BaseApiListBean<ExpandedCallVariableList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<ExpandedCallVariableList>? GetItems() => items;

    public override void SetItems(List<ExpandedCallVariableList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<ExpandedCallVariableList>? items)
    {
        this.items = items;
    }
  }
}

}