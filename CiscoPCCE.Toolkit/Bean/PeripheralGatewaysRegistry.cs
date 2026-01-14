using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class PeripheralGatewaysRegistry : BaseApiBean
    {
        [XmlElement("clientType")]
        public string? ClientType { get; set; }

        [XmlElement("logicalControllerID")]
        public int? LogicalControllerID { get; set; }

        [XmlArray("peripherals")]
        [XmlArrayItem("peripheral")]
        public List<PeripheralWithRoutingClient>? PeripheralDetails { get; set; }

        [XmlElement("pgName")]
        public string? PgName { get; set; }
    }
}