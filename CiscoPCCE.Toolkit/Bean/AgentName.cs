using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("agentName")]
public class AgentName : BaseApiBean {
  private int? agentId;
  private string? agentURL;
  private string? enterpriseName;

  public int? AgentId
  {
      get => agentId;
      set => agentId = value;
  }


  public void setAgentId(int? agentId) {
     this.agentId = agentId;
  }

  public string? AgentURL
  {
      get => agentURL;
      set => agentURL = value;
  }


  public void setAgentURL(String agentURL) {
     this.agentURL = agentURL;
  }

  public string? EnterpriseName
  {
      get => enterpriseName;
      set => enterpriseName = value;
  }


  public void setEnterpriseName(String enterpriseName) {
     this.enterpriseName = enterpriseName;
  }


}

}