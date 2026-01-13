using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("inventoryautodiscovery")]
    public class InventoryAutoDiscovery : BaseApiBean
    {
        [XmlElement("disabled")]
        public bool? Disabled { get; set; }
    }
}