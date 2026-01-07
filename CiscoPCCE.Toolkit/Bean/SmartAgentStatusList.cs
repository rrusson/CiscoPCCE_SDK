using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("smartAgentStatusList")]
public class SmartAgentStatusList : BaseApiBean {
  
  [XmlElement("smartAgentStatus")]
  public List<SmartAgentStatus>? SmartAgentStatuses { get; set; }

}

}