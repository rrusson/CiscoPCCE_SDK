using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





public class CVPLabel : BaseApiBean {
  private string? pattern;
  private string? routingClientName;

  public string? Pattern
  {
      get => pattern;
      set => pattern = value;
  }


  public void setPattern(String pattern) {
     this.pattern = pattern;
  }

  public string? RoutingClientName
  {
      get => routingClientName;
      set => routingClientName = value;
  }


  public void setRoutingClientName(String routingClientName) {
     this.routingClientName = routingClientName;
  }


}

}