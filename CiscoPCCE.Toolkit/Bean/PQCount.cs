using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("PQAgentCount")]
public class PQCount : BaseApiBean {
      
  public int? AgentCount { get; set; }

  [XmlElement("agentNameList")]
  [XmlElement("agentName")]
  public List<AgentName>? AgentNameList { get; set; }

  public string? RefURL { get; set; }

}

}