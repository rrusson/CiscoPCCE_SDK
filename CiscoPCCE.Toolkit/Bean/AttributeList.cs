using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("attribute")
[XmlRoot("results")]
public class AttributeList : BaseApiBean {
  private List<AttributeBase>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("attributes")]
  [XmlElement("attribute")]
  public List<AttributeBase>? Items
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

  // Path("attribute")
  [XmlRoot("results")]
  public class AttributeListList : BaseApiListBean<AttributeList> {    public override List<AttributeList>? GetItems() => items;

    public override void SetItems(List<AttributeList>? value) => items = value;

  }
}

}