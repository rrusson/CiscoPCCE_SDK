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


  public void setTotalVariableCtiSize(int? totalVariableCtiSize) {
     this.totalVariableCtiSize = totalVariableCtiSize;
  }

  public int? TotalVariableSize
  {
      get => totalVariableSize;
      set => totalVariableSize = value;
  }


  public void setTotalVariableSize(int? totalVariableSize) {
     this.totalVariableSize = totalVariableSize;
  }


  // Path("expandedcallvariable")
  [XmlRoot("results")]
  public class ExpandedCallVariableGlobalInfoList : BaseApiListBean<ExpandedCallVariableGlobalInfo> {
    [XmlElement("globalInfos")]
    [XmlElement("globalInfo")]
   
    public override List<ExpandedCallVariableGlobalInfo>? GetItems() => items;

    public override void SetItems(List<ExpandedCallVariableGlobalInfo>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<ExpandedCallVariableGlobalInfo>? items)
    {
        this.items = items;
    }
  }
}

}