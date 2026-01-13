using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("peripheral")
    [XmlRoot("results")]
    public class PeripheralList : BaseApiBean
    {
        [XmlArray("peripherals")]
        [XmlArrayItem("peripheral")]
        public List<PeripheralWithRoutingClient>? Items { get; set; }

        [XmlElement("pageInfo")]
        public required PageInfo PageInfo { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }
    }
}