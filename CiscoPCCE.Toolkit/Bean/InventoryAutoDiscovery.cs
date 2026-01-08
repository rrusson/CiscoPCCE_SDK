using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("systemmgmt")
    [XmlRoot("inventoryautodiscovery")]
    public class InventoryAutoDiscovery : BaseApiBean
    {
        [XmlElement("disabled")]
        public bool? Disabled { get; set; }

        // Path("systemmgmt")
        [XmlRoot("results")]
        public class InventoryAutoDiscoveryList : BaseApiListBean<InventoryAutoDiscovery>
        {
            public override List<InventoryAutoDiscovery>? GetItems() => Items;

            public override void SetItems(List<InventoryAutoDiscovery>? value) => Items = value;
        }
    }
}