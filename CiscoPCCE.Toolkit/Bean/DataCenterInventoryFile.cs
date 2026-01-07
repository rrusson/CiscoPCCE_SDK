using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("datacenter")]
    public class DataCenterInventoryFile : BaseApiBean
    {
        public required InventoryFile InventoryFile { get; set; }

        public string? Name { get; set; }
    }
}