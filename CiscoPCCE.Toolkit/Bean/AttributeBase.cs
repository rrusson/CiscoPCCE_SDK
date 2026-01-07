using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("attribute")
public class AttributeBase : BaseApiBean {
                          
  public int? AgentCount { get; set; }

  public string? BaseUrlfromRefUrl { get; set; }

  public int? ChangeStamp { get; set; }

  public string? CorrelationId { get; set; }

  public int? DataType { get; set; }

  public string? DefaultValue { get; set; }

  public ReferenceBean Department { get; set; }

  public string? Description { get; set; }

  public string? IdFromRefUrl { get; set; }

  public bool? MarkDeletable { get; set; }

  public string? Name { get; set; }

  public string? RefURL { get; set; }

  public int? SelectedAgentCount { get; set; }

}

}