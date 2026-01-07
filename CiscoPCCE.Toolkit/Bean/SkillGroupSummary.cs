using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("skillgroup")
[XmlRoot("skillGroupSummary")]
public class SkillGroupSummary : BaseApiBean {
  private int? agentCount;
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private ReferenceBean datacenter;
  private ReferenceBean department;
  private string? description;
  private string? idFromRefUrl;
  private bool? markDeletable;
  private string? name;
  private PeripheralRef peripheral;
  private int? peripheralNumber;
  private ReferenceBean peripheralSet;
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

  public ReferenceBean Datacenter
  {
      get => datacenter;
      set => datacenter = value;
  }


  public void setDatacenter(ReferenceBean datacenter) {
     this.datacenter = datacenter;
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

  public PeripheralRef Peripheral
  {
      get => peripheral;
      set => peripheral = value;
  }


  public void setPeripheral(PeripheralRef peripheral) {
     this.peripheral = peripheral;
  }

  public int? PeripheralNumber
  {
      get => peripheralNumber;
      set => peripheralNumber = value;
  }


  public void setPeripheralNumber(int? peripheralNumber) {
     this.peripheralNumber = peripheralNumber;
  }

  [XmlElement("peripheralSet")]
  public ReferenceBean PeripheralSet
  {
      get => peripheralSet;
      set => peripheralSet = value;
  }


  public void setPeripheralSet(ReferenceBean peripheralSet) {
     this.peripheralSet = peripheralSet;
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


  // Path("skillgroup")
  [XmlRoot("results")]
  public class SkillGroupSummaryList : BaseApiListBean<SkillGroupSummary> {
    [XmlElement("skillGroupSummarys")]
    [XmlElement("skillGroupSummary")]
   
    public override List<SkillGroupSummary>? GetItems() => items;

    public override void SetItems(List<SkillGroupSummary>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<SkillGroupSummary>? items)
    {
        this.items = items;
    }
  }
}

}