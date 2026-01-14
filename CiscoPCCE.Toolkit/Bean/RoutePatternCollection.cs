using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("routePatternCollection")]
    public class RoutePatternCollection : BaseApiBean
    {
        [XmlElement("routePatternConfigs")]
        public required Collection RoutePatternConfigs { get; set; }
    }
}