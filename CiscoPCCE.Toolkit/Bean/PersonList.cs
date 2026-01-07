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

  public PermissionInfo PermissionInfo
  {
      get => permissionInfo;
      set => permissionInfo = value;
  }

  // Path("agent")
  [XmlRoot("results")]
  public class PersonListList : BaseApiListBean<PersonList> {    public override List<PersonList>? GetItems() => items;

    public override void SetItems(List<PersonList>? value) => items = value;

  }
}

}