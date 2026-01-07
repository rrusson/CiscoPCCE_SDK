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

  [XmlElement("agents")]
  [XmlElement("agent")]
  public List<ReferenceBean>? Agents
  {
      get => agents;
      set => agents = value;
  }

  [XmlElement("agentsAdded")]
  [XmlElement("agent")]
  public List<ReferenceBean>? AgentsAdded
  {
      get => agentsAdded;
      set => agentsAdded = value;
  }

  [XmlElement("agentsRemoved")]
  [XmlElement("agent")]
  public List<ReferenceBean>? AgentsRemoved
  {
      get => agentsRemoved;
      set => agentsRemoved = value;
  }

  public string? BaseUrlfromRefUrl
  {
      get => baseUrlfromRefUrl;
      set => baseUrlfromRefUrl = value;
  }

  public ReferenceBean BucketInterval
  {
      get => bucketInterval;
      set => bucketInterval = value;
  }

  public ReferenceBean CampaignRef
  {
      get => campaignRef;
      set => campaignRef = value;
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

  public ReferenceBean Datacenter
  {
      get => datacenter;
      set => datacenter = value;
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

  public ReferenceBean MediaRoutingDomain
  {
      get => mediaRoutingDomain;
      set => mediaRoutingDomain = value;
  }

  public string? Name
  {
      get => name;
      set => name = value;
  }

  public PeripheralRef Peripheral
  {
      get => peripheral;
      set => peripheral = value;
  }

  public int? PeripheralNumber
  {
      get => peripheralNumber;
      set => peripheralNumber = value;
  }

  [XmlElement("peripheralSet")]
  public ReferenceBean PeripheralSet
  {
      get => peripheralSet;
      set => peripheralSet = value;
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

  public int? ServiceLevelThreshold
  {
      get => serviceLevelThreshold;
      set => serviceLevelThreshold = value;
  }

  public int? ServiceLevelType
  {
      get => serviceLevelType;
      set => serviceLevelType = value;
  }

  // Path("skillgroup")
  [XmlRoot("results")]
  public class SkillGroupList : BaseApiListBean<SkillGroup> {    public override List<SkillGroup>? GetItems() => items;

    public override void SetItems(List<SkillGroup>? value) => items = value;

  }
}

}