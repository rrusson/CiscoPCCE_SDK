using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("applicationpath")
[XmlRoot("results")]
public class ApplicationPathList : BaseApiBean {
  private List<ApplicationPath>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("applicationPaths")]
  [XmlElement("applicationPath")]
  public List<ApplicationPath>? Items
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

  // Path("applicationpath")
  [XmlRoot("results")]
  public class ApplicationPathListList : BaseApiListBean<ApplicationPathList> {    public override List<ApplicationPathList>? GetItems() => items;

    public override void SetItems(List<ApplicationPathList>? value) => items = value;

  }
}

}