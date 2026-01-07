using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("expandedcallvariable")
[XmlRoot("globalInfo")]
public class ExpandedCallVariableGlobalInfo : BaseApiBean {
  private int? totalVariableCtiSize;
  private int? totalVariableSize;

  public int? TotalVariableCtiSize
  {
      get => totalVariableCtiSize;
      set => totalVariableCtiSize = value;
  }

  public int? TotalVariableSize
  {
      get => totalVariableSize;
      set => totalVariableSize = value;
  }

  // Path("expandedcallvariable")
  [XmlRoot("results")]
  public class ExpandedCallVariableGlobalInfoList : BaseApiListBean<ExpandedCallVariableGlobalInfo> {    public override List<ExpandedCallVariableGlobalInfo>? GetItems() => items;

    public override void SetItems(List<ExpandedCallVariableGlobalInfo>? value) => items = value;

  }
}

}