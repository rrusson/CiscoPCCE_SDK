using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("/agentteam")
[XmlRoot("results")]
public class AgentTeamList : BaseApiBean {
  private List<AgentTeamBase>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("agentTeams")]
  [XmlElement("agentTeam")]
  public List<AgentTeamBase>? Items
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

  // Path("/agentteam")
  [XmlRoot("results")]
  public class AgentTeamListList : BaseApiListBean<AgentTeamList> {    public override List<AgentTeamList>? GetItems() => items;

    public override void SetItems(List<AgentTeamList>? value) => items = value;

  }
}

}