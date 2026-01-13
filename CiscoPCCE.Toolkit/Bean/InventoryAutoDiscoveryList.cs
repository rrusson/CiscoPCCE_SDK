using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("systemmgmt")
    [XmlRoot("results")]
    public class InventoryAutoDiscoveryList : BaseApiList<InventoryAutoDiscovery>
    {
        [XmlArray("inventoryautodiscoverys")]
        [XmlArrayItem("inventoryautodiscovery")]
        public new List<InventoryAutoDiscovery>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}