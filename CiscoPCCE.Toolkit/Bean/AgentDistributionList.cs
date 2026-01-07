using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("agentdistribution")
[XmlRoot("results")]
public class AgentDistributionList : BaseApiBean {
  private List<AgentDistribution>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("agentDistributions")]
  [XmlElement("agentDistribution")]
  public List<AgentDistribution>? Items
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

  // Path("agentdistribution")
  [XmlRoot("results")]
  public class AgentDistributionListList : BaseApiListBean<AgentDistributionList> {    public override List<AgentDistributionList>? GetItems() => items;

    public override void SetItems(List<AgentDistributionList>? value) => items = value;

  }
}

}