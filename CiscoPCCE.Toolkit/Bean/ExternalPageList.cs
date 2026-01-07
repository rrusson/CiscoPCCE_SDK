using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("externalpage")
[XmlRoot("results")]
public class ExternalPageList : BaseApiBean {
  private List<ExternalPage>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("externalpages")]
  [XmlElement("externalpage")]
  public List<ExternalPage>? Items
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

  // Path("externalpage")
  [XmlRoot("results")]
  public class ExternalPageListList : BaseApiListBean<ExternalPageList> {    public override List<ExternalPageList>? GetItems() => items;

    public override void SetItems(List<ExternalPageList>? value) => items = value;

  }
}

}