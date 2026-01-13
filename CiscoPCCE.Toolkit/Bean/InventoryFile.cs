using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("inventoryFile")]
    public class InventoryFile : BaseApiBean
    {
        [XmlElement("content")]
        public string? Content { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }
    }
}