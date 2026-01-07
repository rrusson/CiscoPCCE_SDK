using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("enterpriseroute")
[XmlRoot("results")]
public class EnterpriseSkillGroupList : BaseApiBean {
  private List<EnterpriseSkillGroup>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("EnterpriseSkillGroups")]
  [XmlElement("EnterpriseSkillGroup")]
  public List<EnterpriseSkillGroup>? Items
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


  // Path("enterpriseroute")
  [XmlRoot("results")]
  public class EnterpriseSkillGroupListList : BaseApiListBean<EnterpriseSkillGroupList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<EnterpriseSkillGroupList>? GetItems() => items;

    public override void SetItems(List<EnterpriseSkillGroupList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<EnterpriseSkillGroupList>? items)
    {
        this.items = items;
    }
  }
}

}