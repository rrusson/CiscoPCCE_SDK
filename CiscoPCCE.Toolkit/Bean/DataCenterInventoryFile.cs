using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("datacenter")]
    public class DataCenterInventoryFile : BaseApiBean
    {
        [XmlElement("inventoryFile")]
        public required InventoryFile InventoryFile { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }
    }
}