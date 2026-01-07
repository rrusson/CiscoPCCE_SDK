using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("skillgroup")
[XmlRoot("results")]
public class SkillGroupList : BaseApiBean {
  private List<SkillGroupBase>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("skillGroups")]
  [XmlElement("skillGroup")]
  public List<SkillGroupBase>? Items
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

  // Path("skillgroup")
  [XmlRoot("results")]
  public class SkillGroupListList : BaseApiListBean<SkillGroupList> {    public override List<SkillGroupList>? GetItems() => items;

    public override void SetItems(List<SkillGroupList>? value) => items = value;

  }
}

}