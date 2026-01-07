using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("agenttargetingrule")
[XmlRoot("agentTargetingRule")]
public class AgentTargetingRule : BaseApiBean {
  private List<AgentTargetingRuleRange>? agentTargetingRuleRanges;
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private ReferenceBean department;
  private string? description;
  private string? expression;
  private string? idFromRefUrl;
  private string? name;
  private PeripheralRef peripheral;
  private string? refURL;
  private List<ReferenceBean>? routingClients;
  private short? ruleType;

  [XmlElement("ranges")]
  [XmlElement("range")]
  public List<AgentTargetingRuleRange>? AgentTargetingRuleRanges
  {
      get => agentTargetingRuleRanges;
      set => agentTargetingRuleRanges = value;
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

  public string? Expression
  {
      get => expression;
      set => expression = value;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
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

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  [XmlElement("routingClients")]
  [XmlElement("routingClient")]
  public List<ReferenceBean>? RoutingClients
  {
      get => routingClients;
      set => routingClients = value;
  }

  public short? RuleType
  {
      get => ruleType;
      set => ruleType = value;
  }

  // Path("agenttargetingrule")
  [XmlRoot("results")]
  public class AgentTargetingRuleList : BaseApiListBean<AgentTargetingRule> {    public override List<AgentTargetingRule>? GetItems() => items;

    public override void SetItems(List<AgentTargetingRule>? value) => items = value;

  }
}

}