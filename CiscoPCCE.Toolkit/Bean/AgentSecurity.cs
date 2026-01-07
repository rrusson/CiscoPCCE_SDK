using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

// Path("agentsecurity")
[XmlRoot("agentSecurity")]
public class AgentSecurity : BaseApiBean {
  private int? agentsWithoutAdvancedHashing;
  private string? baseUrlfromRefUrl;
  private int? changeStamp;
  private string? correlationId;
  private ReferenceBean department;
  private bool? enforceAdvancedHashing;
  private string? idFromRefUrl;
  private string? refURL;
  private int? unsupportedPeripheralGateways;

  public int? AgentsWithoutAdvancedHashing
  {
      get => agentsWithoutAdvancedHashing;
      set => agentsWithoutAdvancedHashing = value;
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

  public bool? EnforceAdvancedHashing
  {
      get => enforceAdvancedHashing;
      set => enforceAdvancedHashing = value;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }

  public int? UnsupportedPeripheralGateways
  {
      get => unsupportedPeripheralGateways;
      set => unsupportedPeripheralGateways = value;
  }

  // Path("agentsecurity")
  [XmlRoot("results")]
  public class AgentSecurityList : BaseApiListBean<AgentSecurity> {    public override List<AgentSecurity>? GetItems() => items;

    public override void SetItems(List<AgentSecurity>? value) => items = value;

  }
}

}