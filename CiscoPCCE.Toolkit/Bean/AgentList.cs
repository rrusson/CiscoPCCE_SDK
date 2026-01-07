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


  // Path("agent")
  [XmlRoot("results")]
  public class AgentListList : BaseApiListBean<AgentList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<AgentList>? GetItems() => items;

    public override void SetItems(List<AgentList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<AgentList>? items)
    {
        this.items = items;
    }
  }
}

}