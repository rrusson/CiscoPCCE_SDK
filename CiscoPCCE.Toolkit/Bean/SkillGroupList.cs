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


  // Path("skillgroup")
  [XmlRoot("results")]
  public class SkillGroupListList : BaseApiListBean<SkillGroupList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<SkillGroupList>? GetItems() => items;

    public override void SetItems(List<SkillGroupList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<SkillGroupList>? items)
    {
        this.items = items;
    }
  }
}

}