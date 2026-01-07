using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("routePatternConfigs")]
public class RoutePatternConfig : BaseApiBean {
        
  public string? DestinationHostOrIP { get; set; }

  public bool? EnableSendCallsToOriginator { get; set; }

  public int RnaTimeoutInSeconds { get; set; }

  public string? RoutePattern { get; set; }

}

}