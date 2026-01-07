using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("smartLicenseComplianceStatus")]
public class SmartLicenseComplianceStatus : BaseApiBean {
    
  public string? ComplianceStatus { get; set; }

  public SmartAgentStatusList SmartAgentStatusList { get; set; }

}

}