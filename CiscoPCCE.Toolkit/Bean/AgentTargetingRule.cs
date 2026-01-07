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
  private Short ruleType;

  [XmlElement("ranges")]
  [XmlElement("range")]
  public List<AgentTargetingRuleRange>? AgentTargetingRuleRanges
  {
      get => agentTargetingRuleRanges;
      set => agentTargetingRuleRanges = value;
  }


  public void setAgentTargetingRuleRanges(List<AgentTargetingRuleRange> agentTargetingRuleRanges) {
     this.agentTargetingRuleRanges = agentTargetingRuleRanges;
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

  public string? Expression
  {
      get => expression;
      set => expression = value;
  }


  public void setExpression(String expression) {
     this.expression = expression;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }


  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
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

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  [XmlElement("routingClients")]
  [XmlElement("routingClient")]
  public List<ReferenceBean>? RoutingClients
  {
      get => routingClients;
      set => routingClients = value;
  }


  public void setRoutingClients(List<ReferenceBean> routingClients) {
     this.routingClients = routingClients;
  }

  public Short RuleType
  {
      get => ruleType;
      set => ruleType = value;
  }


  public void setRuleType(Short ruleType) {
     this.ruleType = ruleType;
  }


  // Path("agenttargetingrule")
  [XmlRoot("results")]
  public class AgentTargetingRuleList : BaseApiListBean<AgentTargetingRule> {
    [XmlElement("agentTargetingRules")]
    [XmlElement("agentTargetingRule")]
   
    public override List<AgentTargetingRule>? GetItems() => items;

    public override void SetItems(List<AgentTargetingRule>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<AgentTargetingRule>? items)
    {
        this.items = items;
    }
  }
}

}