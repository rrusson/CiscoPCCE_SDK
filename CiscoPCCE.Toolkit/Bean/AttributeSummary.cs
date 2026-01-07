using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("attribute")
[XmlRoot("attributeSummary")]
public class AttributeSummary : BaseApiBean {
  private int? agentCount;
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private int? dataType;
  private string? defaultValue;
  private ReferenceBean department;
  private string? description;
  private string? idFromRefUrl;
  private bool? markDeletable;
  private string? name;
  private string? refURL;
  private int? selectedAgentCount;

  public int? AgentCount
  {
      get => agentCount;
      set => agentCount = value;
  }

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }

  public int? ChangeStamp
  {
      get => changeStamp;
      set => changeStamp = value;
  }

  public string? CorrelationId
  {
      get => correlationId;
      set => correlationId = value;
  }

  public int? DataType
  {
      get => dataType;
      set => dataType = value;
  }

  public string? DefaultValue
  {
      get => defaultValue;
      set => defaultValue = value;
  }

  public ReferenceBean Department
  {
      get => department;
      set => department = value;
  }

  public string? Description
  {
      get => description;
      set => description = value;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }

  public bool? MarkDeletable
  {
      get => markDeletable;
      set => markDeletable = value;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  public int? SelectedAgentCount
  {
      get => selectedAgentCount;
      set => selectedAgentCount = value;
  }

  // Path("attribute")
  [XmlRoot("results")]
  public class AttributeSummaryList : BaseApiListBean<AttributeSummary> {    public override List<AttributeSummary>? GetItems() => items;

    public override void SetItems(List<AttributeSummary>? value) => items = value;

  }
}

}