using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("mockInventory")]
    public class MockInventory : BaseApiBean
    {
        [XmlElement("enableMockMode")]
        public bool? EnableMockMode { get; set; }

        [XmlArray("machines")]
        [XmlArrayItem("machine")]
        public List<VMData>? VmDataList { get; set; }
    }
}