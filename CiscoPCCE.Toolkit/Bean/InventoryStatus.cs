using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("machineinventory")
    [XmlRoot("status")]
    public class InventoryStatus : BaseApiBean
    {
        [XmlArray("alerts")]
        [XmlArrayItem("alert")]
        public List<Alert>? Alerts { get; set; }

        [XmlElement("scanInfo")]
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