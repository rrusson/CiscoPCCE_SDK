using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("contactsharegroup")
[XmlRoot("results")]
public class ContactShareGroupList : BaseApiBean {
  private List<ContactShareGroup>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("contactShareGroups")]
  [XmlElement("contactShareGroup")]
  public List<ContactShareGroup>? Items
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

  // Path("contactsharegroup")
  [XmlRoot("results")]
  public class ContactShareGroupListList : BaseApiListBean<ContactShareGroupList> {    public override List<ContactShareGroupList>? GetItems() => items;

    public override void SetItems(List<ContactShareGroupList>? value) => items = value;

  }
}

}