using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

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
            [XmlArray("statuss")]
            [XmlArrayItem("status")]
            public new List<InventoryStatus>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<InventoryStatus>? GetItems() => Items;

            public override void SetItems(List<InventoryStatus>? value) => Items = value;
        }
    }
}