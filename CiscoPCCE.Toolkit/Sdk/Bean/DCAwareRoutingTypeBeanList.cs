using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("results")]
    public class DCAwareRoutingTypeBeanList : BaseApiBean
    {
        [XmlElement("datacenterRoutingTypes")]
        public required DatacenterRoutingTypeBeanList DatacenterRoutingTypes { get; set; }

        [XmlElement("routingTypes")]
        public required RoutingTypeBeanList RoutingTypes { get; set; }
    }
}