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


  public void setAgentsWithoutAdvancedHashing(int? agentsWithoutAdvancedHashing) {
     this.agentsWithoutAdvancedHashing = agentsWithoutAdvancedHashing;
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

  public bool? EnforceAdvancedHashing
  {
      get => enforceAdvancedHashing;
      set => enforceAdvancedHashing = value;
  }


  public void setEnforceAdvancedHashing(Boolean enforceAdvancedHashing) {
     this.enforceAdvancedHashing = enforceAdvancedHashing;
  }

  public string? IdFromRefUrl
  {
      get => idFromRefUrl;
      set => idFromRefUrl = value;
  }


  public void setIdFromRefUrl(String idFromRefUrl) {
     this.idFromRefUrl = idFromRefUrl;
  }

  public string? RefURL
  {
      get => refURL;
      set => refURL = value;
  }


  public void setRefURL(String refURL) {
     this.refURL = refURL;
  }

  public int? UnsupportedPeripheralGateways
  {
      get => unsupportedPeripheralGateways;
      set => unsupportedPeripheralGateways = value;
  }


  public void setUnsupportedPeripheralGateways(int? unsupportedPeripheralGateways) {
     this.unsupportedPeripheralGateways = unsupportedPeripheralGateways;
  }


  // Path("agentsecurity")
  [XmlRoot("results")]
  public class AgentSecurityList : BaseApiListBean<AgentSecurity> {
    [XmlElement("agentSecuritys")]
    [XmlElement("agentSecurity")]
   
    public override List<AgentSecurity>? GetItems() => items;

    public override void SetItems(List<AgentSecurity>? value) => items = value;
    {
        return items;
    }

    public override void SetItems(List<AgentSecurity>? items)
    {
        this.items = items;
    }
  }
}

}