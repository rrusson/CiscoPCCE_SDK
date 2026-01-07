using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("results")]
public class DataCenterList : BaseApiBean {
      
  [XmlElement("datacenters")]
  [XmlElement("datacenter")]
  public List<DataCenter12k>? Items { get; set; }

  public PageInfo PageInfo { get; set; }

  public PermissionInfo PermissionInfo { get; set; }

}

}