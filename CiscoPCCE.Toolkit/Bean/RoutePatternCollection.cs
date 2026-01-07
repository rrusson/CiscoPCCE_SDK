using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("routePatternCollection")]
public class RoutePatternCollection : BaseApiBean {
  private Collection routePatternConfigs;

  public Collection RoutePatternConfigs
  {
      get => routePatternConfigs;
      set => routePatternConfigs = value;
  }


  public void setRoutePatternConfigs(Collection routePatternConfigs) {
     this.routePatternConfigs = routePatternConfigs;
  }


}

}