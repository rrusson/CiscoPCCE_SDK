using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("PQAgentCount")]
public class PQCount : BaseApiBean {
  private int? agentCount;
  private List<AgentName>? agentNameList;
  private string? refURL;

  public int? AgentCount
  {
      get => agentCount;
      set => agentCount = value;
  }


  public void setAgentCount(int? agentCount) {
     this.agentCount = agentCount;
  }

  [XmlElement("agentNameList")]
  [XmlElement("agentName")]
  public List<AgentName>? AgentNameList
  {
      get => agentNameList;
      set => agentNameList = value;
  }


  public void setAgentNameList(List<AgentName> agentNameList) {
     this.agentNameList = agentNameList;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }


}

}