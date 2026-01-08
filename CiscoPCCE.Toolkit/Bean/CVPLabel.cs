using System.Xml.Serialization;

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