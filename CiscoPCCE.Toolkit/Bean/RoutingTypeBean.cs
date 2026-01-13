using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("routingtype")
    [XmlRoot("routingType")]
    public class RoutingTypeBean : BaseApiBean
    {
        [XmlElement("machineType")]
        public string? MachineType { get; set; }

        [XmlElement("state")]
        public State State { get; set; }

        [XmlElement("type")]
        public int? Type { get; set; }
    }
}