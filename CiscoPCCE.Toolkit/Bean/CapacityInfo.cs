using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("capacityInfo")]
public class CapacityInfo : BaseApiBean {
  
  [XmlElement("capacityRules")]
  [XmlElement("capacityRule")]
  public List<CapacityCheckResult>? CapacityCheckResults { get; set; }

}

}