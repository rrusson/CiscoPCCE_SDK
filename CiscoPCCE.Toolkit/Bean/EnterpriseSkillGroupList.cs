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

  public PermissionInfo PermissionInfo
  {
      get => permissionInfo;
      set => permissionInfo = value;
  }

  // Path("enterpriseroute")
  [XmlRoot("results")]
  public class EnterpriseSkillGroupListList : BaseApiListBean<EnterpriseSkillGroupList> {    public override List<EnterpriseSkillGroupList>? GetItems() => items;

    public override void SetItems(List<EnterpriseSkillGroupList>? value) => items = value;

  }
}

}