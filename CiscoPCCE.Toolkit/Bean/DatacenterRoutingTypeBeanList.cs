using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

public class DatacenterRoutingTypeBeanList : BaseApiBean {
      
  [XmlElement("datacenterRoutingType")]
  public List<DatacenterRoutingTypeBean>? Items { get; set; }

  public PageInfo PageInfo { get; set; }

  public PermissionInfo PermissionInfo { get; set; }

}

}