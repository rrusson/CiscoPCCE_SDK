using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("agenttargetingrule")
[XmlRoot("range")]
public class AgentTargetingRuleRange : BaseApiBean {
  private string? highExtension;
  private string? lowExtension;

  public string? HighExtension
  {
      get => highExtension;
      set => highExtension = value;
  }


  public void setHighExtension(String highExtension) {
     this.highExtension = highExtension;
  }

  public string? LowExtension
  {
      get => lowExtension;
      set => lowExtension = value;
  }


  public void setLowExtension(String lowExtension) {
     this.lowExtension = lowExtension;
  }


  // Path("agenttargetingrule")
  [XmlRoot("results")]
  public class AgentTargetingRuleRangeList : BaseApiListBean<AgentTargetingRuleRange> {
    [XmlElement("ranges")]
    [XmlElement("range")]
   
    public override List<AgentTargetingRuleRange>? GetItems() => items;

    public override void SetItems(List<AgentTargetingRuleRange>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<AgentTargetingRuleRange>? items)
    {
        this.items = items;
    }
  }
}

}