using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("machineinventory")
    [XmlRoot("status")]
    public class InventoryStatus : BaseApiBean
    {
        [XmlElement("alerts")]
        [XmlElement("alert")]
        public List<Alert>? Alerts { get; set; }

        public required ScanInfo ScanInfo { get; set; }

        // Path("machineinventory")
        [XmlRoot("results")]
        public class InventoryStatusList : BaseApiListBean<InventoryStatus>
        {
            public override List<InventoryStatus>? GetItems() => Items;

            public override void SetItems(List<InventoryStatus>? value) => Items = value;
        }
    }
}