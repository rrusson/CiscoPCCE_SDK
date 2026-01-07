using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("routePatternCollection")]
public class RoutePatternCollection : BaseApiBean {
  
  public Collection RoutePatternConfigs { get; set; }

}

}