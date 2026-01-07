using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("smartLicenseStatus")]
public class SmartLicenseStatus : BaseApiBean {
      
  public string? AgentEnabled { get; set; }

  public string? SerialNumber { get; set; }

  public string? State { get; set; }

}

}