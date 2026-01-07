using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("results")]
public class PeripheralSetList : BaseApiBean {
      
  [XmlElement("peripheralSets")]
  [XmlElement("peripheralSet")]
  public List<PeripheralSet>? Items { get; set; }

  public PageInfo PageInfo { get; set; }

  public PermissionInfo PermissionInfo { get; set; }

}

}