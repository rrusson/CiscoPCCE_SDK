using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("inventoryUpdateFile")]
    public class InventoryUpdateFile : BaseApiBean
    {
        [XmlElement("category")]
        public InventoryUpdateCategory Category { get; set; }

        [XmlElement("content")]
        public string? Content { get; set; }

        [XmlElement("datacenter")]
        public string? Datacenter { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("operation")]
        public InventoryUpdateOperation Operation { get; set; }

        [XmlElement("peripheralSetName")]
        public string? PeripheralSetName { get; set; }
    }
}