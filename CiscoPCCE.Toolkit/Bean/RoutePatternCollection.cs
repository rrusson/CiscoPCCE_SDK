using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("routePatternCollection")]
    public class RoutePatternCollection : BaseApiBean
    {
        public required Collection RoutePatternConfigs { get; set; }
    }
}