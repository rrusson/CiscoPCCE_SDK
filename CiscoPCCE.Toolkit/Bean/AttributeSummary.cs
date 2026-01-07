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


  public void setAgentCount(int? agentCount) {
     this.agentCount = agentCount;
  }

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }


  public void setBaseUrlfromRefUrl(String baseUrlfromRefUrl) {
     this.baseUrlfromRefUrl = baseUrlfromRefUrl;
  }

  public int? ChangeStamp
  {
      get => changeStamp;
      set => changeStamp = value;
  }


  public void setChangeStamp(int? changeStamp) {
     this.changeStamp = changeStamp;
  }

  public string? CorrelationId
  {
      get => correlationId;
      set => correlationId = value;
  }


  public void setCorrelationId(String correlationId) {
     this.correlationId = correlationId;
  }

  public int? DataType
  {
      get => dataType;
      set => dataType = value;
  }


  public void setDataType(int? dataType) {
     this.dataType = dataType;
  }

  public string? DefaultValue
  {
      get => defaultValue;
      set => defaultValue = value;
  }


  public void setDefaultValue(String defaultValue) {
     this.defaultValue = defaultValue;
  }

  public ReferenceBean Department
  {
      get => department;
      set => department = value;
  }


  public void setDepartment(ReferenceBean department) {
     this.department = department;
  }

  public string? Description
  {
      get => description;
      set => description = value;
  }


  public void setDescription(String description) {
     this.description = description;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }


  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public bool? MarkDeletable
  {
      get => markDeletable;
      set => markDeletable = value;
  }


  public void setMarkDeletable(Boolean markDeletable) {
     this.markDeletable = markDeletable;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }


  public void setName(String name) {
     this.name = name;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public int? SelectedAgentCount
  {
      get => selectedAgentCount;
      set => selectedAgentCount = value;
  }


  public void setSelectedAgentCount(int? selectedAgentCount) {
     this.selectedAgentCount = selectedAgentCount;
  }


  // Path("attribute")
  [XmlRoot("results")]
  public class AttributeSummaryList : BaseApiListBean<AttributeSummary> {
    [XmlElement("attributeSummarys")]
    [XmlElement("attributeSummary")]
   
    public override List<AttributeSummary>? GetItems() => items;

    public override void SetItems(List<AttributeSummary>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<AttributeSummary>? items)
    {
        this.items = items;
    }
  }
}

}