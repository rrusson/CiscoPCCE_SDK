using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("machineinventory")
    [XmlRoot("mockInventory")]
    public class MockInventory : BaseApiBean
    {
        [XmlElement("enableMockMode")]
        public bool? EnableMockMode { get; set; }

        [XmlArray("machines")]
        [XmlArrayItem("machine")]
        public List<VMData>? VmDataList { get; set; }

        // Path("machineinventory")
        [XmlRoot("results")]
        public class MockInventoryList : BaseApiListBean<MockInventory>
        {
            [XmlArray("mockInventorys")]
            [XmlArrayItem("mockInventory")]
            public new List<MockInventory>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<MockInventory>? GetItems() => Items;

            public override void SetItems(List<MockInventory>? value) => Items = value;
        }
    }
}