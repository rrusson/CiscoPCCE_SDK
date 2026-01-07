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


  // Path("contactsharerule")
  [XmlRoot("results")]
  public class ContactShareRuleListList : BaseApiListBean<ContactShareRuleList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<ContactShareRuleList>? GetItems() => items;

    public override void SetItems(List<ContactShareRuleList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<ContactShareRuleList>? items)
    {
        this.items = items;
    }
  }
}

}