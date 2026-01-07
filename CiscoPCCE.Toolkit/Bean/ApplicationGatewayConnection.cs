using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

public class ApplicationGatewayConnection : BaseApiBean {
                  
  public string? Address { get; set; }

  public HeartBeat HeartBeat { get; set; }

  public bool? InService { get; set; }

  public string? InitializationData { get; set; }

  public int? MaxErrors { get; set; }

  public int? Port { get; set; }

  public Session Session { get; set; }

  public ApplicationGatewayPreferredSide Side { get; set; }

  public Timeout Timeout { get; set; }

}

}