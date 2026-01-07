using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("smartLicenseComplianceStatus")]
public class SmartLicenseComplianceStatus : BaseApiBean {
  private string? complianceStatus;
  private SmartAgentStatusList smartAgentStatusList;

  public string? ComplianceStatus
  {
      get => complianceStatus;
      set => complianceStatus = value;
  }


  public void setComplianceStatus(String complianceStatus) {
     this.complianceStatus = complianceStatus;
  }

  public SmartAgentStatusList SmartAgentStatusList
  {
      get => smartAgentStatusList;
      set => smartAgentStatusList = value;
  }


  public void setSmartAgentStatusList(SmartAgentStatusList smartAgentStatusList) {
     this.smartAgentStatusList = smartAgentStatusList;
  }


}

}