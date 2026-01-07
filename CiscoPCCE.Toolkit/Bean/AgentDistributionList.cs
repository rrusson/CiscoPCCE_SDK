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


  // Path("agentdistribution")
  [XmlRoot("results")]
  public class AgentDistributionListList : BaseApiListBean<AgentDistributionList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<AgentDistributionList>? GetItems() => items;

    public override void SetItems(List<AgentDistributionList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<AgentDistributionList>? items)
    {
        this.items = items;
    }
  }
}

}