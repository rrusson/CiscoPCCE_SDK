using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("reportingServer")]
public class ReportingServer : BaseApiBean {
    
  public string? Ip { get; set; }

  public int? MessageBusNumber { get; set; }

}

}