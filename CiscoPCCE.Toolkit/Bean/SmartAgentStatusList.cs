using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("smartAgentStatusList")]
public class SmartAgentStatusList : BaseApiBean {
  private List<SmartAgentStatus>? smartAgentStatuses;

  [XmlElement("smartAgentStatus")]
  public List<SmartAgentStatus>? SmartAgentStatuses
  {
      get => smartAgentStatuses;
      set => smartAgentStatuses = value;
  }


  public void setSmartAgentStatuses(List<SmartAgentStatus> smartAgentStatuses) {
     this.smartAgentStatuses = smartAgentStatuses;
  }


}

}