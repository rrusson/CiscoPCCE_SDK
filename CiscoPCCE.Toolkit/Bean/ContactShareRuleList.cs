using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("contactsharerule")
[XmlRoot("results")]
public class ContactShareRuleList : BaseApiBean {
  private List<ContactShareRule>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("contactShareRules")]
  [XmlElement("contactShareRule")]
  public List<ContactShareRule>? Items
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

  // Path("contactsharerule")
  [XmlRoot("results")]
  public class ContactShareRuleListList : BaseApiListBean<ContactShareRuleList> {    public override List<ContactShareRuleList>? GetItems() => items;

    public override void SetItems(List<ContactShareRuleList>? value) => items = value;

  }
}

}