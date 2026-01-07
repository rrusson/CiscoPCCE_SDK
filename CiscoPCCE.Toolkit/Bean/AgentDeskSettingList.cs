using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("agentdesksetting")
[XmlRoot("results")]
public class AgentDeskSettingList : BaseApiBean {
  private List<AgentDeskSetting>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("agentDeskSettings")]
  [XmlElement("agentDeskSetting")]
  public List<AgentDeskSetting>? Items
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

  // Path("agentdesksetting")
  [XmlRoot("results")]
  public class AgentDeskSettingListList : BaseApiListBean<AgentDeskSettingList> {    public override List<AgentDeskSettingList>? GetItems() => items;

    public override void SetItems(List<AgentDeskSettingList>? value) => items = value;

  }
}

}