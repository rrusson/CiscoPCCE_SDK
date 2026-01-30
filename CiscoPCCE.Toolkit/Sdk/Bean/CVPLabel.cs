using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class CVPLabel : BaseApiBean
    {
        [XmlElement("pattern")]
        public string? Pattern { get; set; }

        [XmlElement("routingClientName")]
        public string? RoutingClientName { get; set; }
    }
}