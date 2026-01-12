using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("routingtype")
    [XmlRoot("datacenterRoutingType")]
    public class DatacenterRoutingTypeBean : BaseApiBean
    {
        [XmlElement("datacenter")]
        public required ReferenceBean Datacenter { get; set; }

        [XmlElement("peripheralSet")]
        public required ReferenceBean PeripheralSet { get; set; }

        [XmlElement("routingTypes")]
        public required RoutingTypeBeanList RoutingTypes { get; set; }
        
    }
}