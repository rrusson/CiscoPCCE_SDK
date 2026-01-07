using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





// Path("skillgroup")
[XmlRoot("skillGroup")]
public class SkillGroup : BaseApiBean {
  private int? agentCount;
  private List<ReferenceBean>? agents;
  private List<ReferenceBean>? agentsAdded;
  private List<ReferenceBean>? agentsRemoved;
  private string? baseUrlfromRefUrl;
  private ReferenceBean bucketInterval;
  private ReferenceBean campaignRef;
  private int? changeStamp;
  private string? correlationId;
  private ReferenceBean datacenter;
  private ReferenceBean department;
  private string? description;
  private string? idFromRefUrl;
  private bool? markDeletable;
  private ReferenceBean mediaRoutingDomain;
  private string? name;
  private PeripheralRef peripheral;
  private int? peripheralNumber;
  private ReferenceBean peripheralSet;
  private string? refURL;
  private int? selectedAgentCount;
  private int? serviceLevelThreshold;
  private int? serviceLevelType;

  public int? AgentCount
  {
      get => agentCount;
      set => agentCount = value;
  }


  public void setAgentCount(int? agentCount) {
     this.agentCount = agentCount;
  }

  [XmlElement("agents")]
  [XmlElement("agent")]
  public List<ReferenceBean>? Agents
  {
      get => agents;
      set => agents = value;
  }


  public void setAgents(List<ReferenceBean> agents) {
     this.agents = agents;
  }

  [XmlElement("agentsAdded")]
  [XmlElement("agent")]
  public List<ReferenceBean>? AgentsAdded
  {
      get => agentsAdded;
      set => agentsAdded = value;
  }


  public void setAgentsAdded(List<ReferenceBean> agentsAdded) {
     this.agentsAdded = agentsAdded;
  }

  [XmlElement("agentsRemoved")]
  [XmlElement("agent")]
  public List<ReferenceBean>? AgentsRemoved
  {
      get => agentsRemoved;
      set => agentsRemoved = value;
  }


  public void setAgentsRemoved(List<ReferenceBean> agentsRemoved) {
     this.agentsRemoved = agentsRemoved;
  }

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }


  public void setBaseUrlfromRefUrl(String baseUrlfromRefUrl) {
     this.baseUrlfromRefUrl = baseUrlfromRefUrl;
  }

  public ReferenceBean BucketInterval
  {
      get => bucketInterval;
      set => bucketInterval = value;
  }


  public void setBucketInterval(ReferenceBean bucketInterval) {
     this.bucketInterval = bucketInterval;
  }

  public ReferenceBean CampaignRef
  {
      get => campaignRef;
      set => campaignRef = value;
  }


  public void setCampaignRef(ReferenceBean campaignRef) {
     this.campaignRef = campaignRef;
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

  public ReferenceBean MediaRoutingDomain
  {
      get => mediaRoutingDomain;
      set => mediaRoutingDomain = value;
  }


  public void setMediaRoutingDomain(ReferenceBean mediaRoutingDomain) {
     this.mediaRoutingDomain = mediaRoutingDomain;
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

  public int? ServiceLevelThreshold
  {
      get => serviceLevelThreshold;
      set => serviceLevelThreshold = value;
  }


  public void setServiceLevelThreshold(int? serviceLevelThreshold) {
     this.serviceLevelThreshold = serviceLevelThreshold;
  }

  public int? ServiceLevelType
  {
      get => serviceLevelType;
      set => serviceLevelType = value;
  }


  public void setServiceLevelType(int? serviceLevelType) {
     this.serviceLevelType = serviceLevelType;
  }


  // Path("skillgroup")
  [XmlRoot("results")]
  public class SkillGroupList : BaseApiListBean<SkillGroup> {
    [XmlElement("skillGroups")]
    [XmlElement("skillGroup")]
   
    public override List<SkillGroup>? GetItems() => items;

    public override void SetItems(List<SkillGroup>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<SkillGroup>? items)
    {
        this.items = items;
    }
  }
}

}