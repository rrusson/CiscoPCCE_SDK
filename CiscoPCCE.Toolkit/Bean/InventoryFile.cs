using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("inventoryFile")]
    public class InventoryFile : BaseApiBean
    {
        public string? Content { get; set; }

        public string? Name { get; set; }
    }
}