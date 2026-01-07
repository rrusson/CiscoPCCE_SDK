using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("administrator")
[XmlRoot("results")]
public class AdministratorList : BaseApiBean {
  private List<Administrator>? items;

  [XmlElement("administrators")]
  [XmlElement("administrator")]
  public List<Administrator>? Items
  {
      get => items;
      set => items = value;
  }

  public PageInfo PageInfo { get; set; }

  public PermissionInfo PermissionInfo { get; set; }

  // Path("administrator")
  [XmlRoot("results")]
  public class AdministratorListList : BaseApiListBean<AdministratorList> {    public override List<AdministratorList>? GetItems() => items;

    public override void SetItems(List<AdministratorList>? value) => items = value;

  }
}

}