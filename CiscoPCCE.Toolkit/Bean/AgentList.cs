using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("agent")
[XmlRoot("results")]
public class AgentList : BaseApiBean {
  private List<AgentBase>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("agents")]
  [XmlElement("agent")]
  public List<AgentBase>? Items
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

  // Path("agent")
  [XmlRoot("results")]
  public class AgentListList : BaseApiListBean<AgentList> {    public override List<AgentList>? GetItems() => items;

    public override void SetItems(List<AgentList>? value) => items = value;

  }
}

}