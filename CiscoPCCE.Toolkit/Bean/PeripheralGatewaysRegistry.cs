using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    public class PeripheralGatewaysRegistry : BaseApiBean
    {
        public string? ClientType { get; set; }

        public int? LogicalControllerID { get; set; }

        [XmlElement("peripherals")]
        [XmlElement("peripheral")]
        public List<PeripheralWithRoutingClient>? PeripheralDetails { get; set; }

        public string? PgName { get; set; }
    }
}