using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("agenttargetingrule")
[XmlRoot("results")]
public class AgentTargetingRuleList : BaseApiBean {
  private List<AgentTargetingRule>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("agentTargetingRules")]
  [XmlElement("agentTargetingRule")]
  public List<AgentTargetingRule>? Items
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

  // Path("agenttargetingrule")
  [XmlRoot("results")]
  public class AgentTargetingRuleListList : BaseApiListBean<AgentTargetingRuleList> {    public override List<AgentTargetingRuleList>? GetItems() => items;

    public override void SetItems(List<AgentTargetingRuleList>? value) => items = value;

  }
}

}