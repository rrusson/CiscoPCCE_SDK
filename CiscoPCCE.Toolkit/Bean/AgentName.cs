using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("agentName")]
public class AgentName : BaseApiBean {
      
  public int? AgentId { get; set; }

  public string? AgentURL { get; set; }

  public string? EnterpriseName { get; set; }

}

}