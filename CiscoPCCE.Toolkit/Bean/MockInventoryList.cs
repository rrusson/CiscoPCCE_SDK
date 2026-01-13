using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("machineinventory")
    [XmlRoot("results")]
    public class MockInventoryList : BaseApiList<MockInventory>
    {
        [XmlArray("mockInventorys")]
        [XmlArrayItem("mockInventory")]
        public new List<MockInventory>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}