using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("reportingConfig")]
public class ReportingInitConfig : BaseApiBean {
      
  public string? DeviceId { get; set; }

  public string? HostName { get; set; }

  public string? IpAddress { get; set; }

}

}