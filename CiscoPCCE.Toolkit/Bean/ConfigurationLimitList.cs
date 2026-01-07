using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("configurationlimit")
[XmlRoot("results")]
public class ConfigurationLimitList : BaseApiBean {
  private List<ConfigurationLimit>? items;
  private PageInfo pageInfo;
  private PermissionInfo permissionInfo;

  [XmlElement("configurationlimits")]
  [XmlElement("configurationLimit")]
  public List<ConfigurationLimit>? Items
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

  // Path("configurationlimit")
  [XmlRoot("results")]
  public class ConfigurationLimitListList : BaseApiListBean<ConfigurationLimitList> {    public override List<ConfigurationLimitList>? GetItems() => items;

    public override void SetItems(List<ConfigurationLimitList>? value) => items = value;

  }
}

}