using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("agent")
[XmlRoot("results")]
public class PersonList : BaseApiBean {
  private List<Person>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("persons")]
  [XmlElement("person")]
  public List<Person>? Items
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
  public class PersonListList : BaseApiListBean<PersonList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<PersonList>? GetItems() => items;

    public override void SetItems(List<PersonList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<PersonList>? items)
    {
        this.items = items;
    }
  }
}

}