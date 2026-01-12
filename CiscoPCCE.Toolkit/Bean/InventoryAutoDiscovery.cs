using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("systemmgmt")
    [XmlRoot("inventoryautodiscovery")]
    public class InventoryAutoDiscovery : BaseApiBean
    {
        [XmlElement("disabled")]
        public bool? Disabled { get; set; }
        
    }
}