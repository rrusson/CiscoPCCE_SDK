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
            [XmlArray("inventoryautodiscoverys")]
            [XmlArrayItem("inventoryautodiscovery")]
            public new List<InventoryAutoDiscovery>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<InventoryAutoDiscovery>? GetItems() => Items;

            public override void SetItems(List<InventoryAutoDiscovery>? value) => Items = value;
        }
    }
}