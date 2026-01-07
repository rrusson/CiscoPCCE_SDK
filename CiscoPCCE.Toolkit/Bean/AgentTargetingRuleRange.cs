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

  public string? LowExtension
  {
      get => lowExtension;
      set => lowExtension = value;
  }

  // Path("agenttargetingrule")
  [XmlRoot("results")]
  public class AgentTargetingRuleRangeList : BaseApiListBean<AgentTargetingRuleRange> {    public override List<AgentTargetingRuleRange>? GetItems() => items;

    public override void SetItems(List<AgentTargetingRuleRange>? value) => items = value;

  }
}

}