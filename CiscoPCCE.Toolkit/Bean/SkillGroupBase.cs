using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("skillgroup")
public class SkillGroupBase : BaseApiBean {
                              
  public int? AgentCount { get; set; }

  public string? BaseUrlfromRefUrl { get; set; }

  public int? ChangeStamp { get; set; }

  public string? CorrelationId { get; set; }

  public ReferenceBean Datacenter { get; set; }

  public ReferenceBean Department { get; set; }

  public string? Description { get; set; }

  public string? IdFromRefUrl { get; set; }

  public bool? MarkDeletable { get; set; }

  public string? Name { get; set; }

  public PeripheralRef Peripheral { get; set; }

  public int? PeripheralNumber { get; set; }

  [XmlElement("peripheralSet")]
  public ReferenceBean PeripheralSet { get; set; }

  public string? RefURL { get; set; }

  public int? SelectedAgentCount { get; set; }

}

}