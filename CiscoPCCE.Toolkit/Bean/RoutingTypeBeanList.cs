using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

public class RoutingTypeBeanList : BaseApiBean {
      
  [XmlElement("routingType")]
  public List<RoutingTypeBean>? Items { get; set; }

  public PageInfo PageInfo { get; set; }

  public PermissionInfo PermissionInfo { get; set; }

}

}