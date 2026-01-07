using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("results")]
public class MenuList : BaseApiBean {
      
  [XmlElement("menus")]
  [XmlElement("menu")]
  public List<Menu>? Items { get; set; }

  public PageInfo PageInfo { get; set; }

  public PermissionInfo PermissionInfo { get; set; }

}

}