using System.Xml.Serialization;

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
            public override List<MockInventory>? GetItems() => Items;

            public override void SetItems(List<MockInventory>? value) => Items = value;
        }
    }
}