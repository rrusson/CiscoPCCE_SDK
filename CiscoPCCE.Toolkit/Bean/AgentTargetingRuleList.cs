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


  // Path("agenttargetingrule")
  [XmlRoot("results")]
  public class AgentTargetingRuleListList : BaseApiListBean<AgentTargetingRuleList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<AgentTargetingRuleList>? GetItems() => items;

    public override void SetItems(List<AgentTargetingRuleList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<AgentTargetingRuleList>? items)
    {
        this.items = items;
    }
  }
}

}