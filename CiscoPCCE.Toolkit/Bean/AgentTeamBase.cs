using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("/agentteam")
public class AgentTeamBase : BaseApiBean {
                              
  public int? AgentCount { get; set; }

  public string? BaseUrlfromRefUrl { get; set; }

  public int? ChangeStamp { get; set; }

  public string? CorrelationId { get; set; }

  public ReferenceBean Datacenter { get; set; }

  public ReferenceBean Department { get; set; }

  public string? Description { get; set; }

  public ReferenceBean DialedNumber { get; set; }

  public string? IdFromRefUrl { get; set; }

  public string? Name { get; set; }

  public PeripheralRef Peripheral { get; set; }

  public int? PeripheralId { get; set; }

  [XmlElement("peripheralSet")]
  public ReferenceBean PeripheralSet { get; set; }

  public string? RefURL { get; set; }

  public int? SupervisorCount { get; set; }

}

}