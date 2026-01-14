using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("machineinventory")
    [XmlRoot("results")]
    public class InventoryStatusList : BaseApiList<InventoryStatus>
    {
        [XmlArray("statuss")]
        [XmlArrayItem("status")]
        public new List<InventoryStatus>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}