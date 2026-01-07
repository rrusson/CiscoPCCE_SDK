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


  // Path("configurationlimit")
  [XmlRoot("results")]
  public class ConfigurationLimitListList : BaseApiListBean<ConfigurationLimitList> {
    [XmlElement("resultss")]
    [XmlElement("results")]
   
    public override List<ConfigurationLimitList>? GetItems() => items;

    public override void SetItems(List<ConfigurationLimitList>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<ConfigurationLimitList>? items)
    {
        this.items = items;
    }
  }
}

}