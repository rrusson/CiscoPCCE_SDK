using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("machineinventory")
    [XmlRoot("mockInventory")]
    public class MockInventory : BaseApiBean
    {
        public bool? EnableMockMode { get; set; }

        [XmlElement("machines")]
        [XmlElement("machine")]
        public List<VMData>? VmDataList { get; set; }

        // Path("machineinventory")
        [XmlRoot("results")]
        public class MockInventoryList : BaseApiListBean<MockInventory>
        {
            public override List<MockInventory>? GetItems() => Items;

            public override void SetItems(List<MockInventory>? value) => Items = value;
        }
    }
}