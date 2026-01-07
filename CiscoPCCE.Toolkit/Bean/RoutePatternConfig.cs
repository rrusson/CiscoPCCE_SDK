using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("routePatternConfigs")]
public class RoutePatternConfig : BaseApiBean {
  private string? destinationHostOrIP;
  private bool? enableSendCallsToOriginator;
  private int rnaTimeoutInSeconds;
  private string? routePattern;

  public string? DestinationHostOrIP
  {
      get => destinationHostOrIP;
      set => destinationHostOrIP = value;
  }


  public void setDestinationHostOrIP(String destinationHostOrIP) {
     this.destinationHostOrIP = destinationHostOrIP;
  }

  public bool? EnableSendCallsToOriginator
  {
      get => enableSendCallsToOriginator;
      set => enableSendCallsToOriginator = value;
  }


  public void setEnableSendCallsToOriginator(bool? enableSendCallsToOriginator) {
     this.enableSendCallsToOriginator = enableSendCallsToOriginator;
  }

  public int RnaTimeoutInSeconds
  {
      get => rnaTimeoutInSeconds;
      set => rnaTimeoutInSeconds = value;
  }


  public void setRnaTimeoutInSeconds(int rnaTimeoutInSeconds) {
     this.rnaTimeoutInSeconds = rnaTimeoutInSeconds;
  }

  public string? RoutePattern
  {
      get => routePattern;
      set => routePattern = value;
  }


  public void setRoutePattern(String routePattern) {
     this.routePattern = routePattern;
  }


}

}