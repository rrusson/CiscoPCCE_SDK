using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("address")]
    public class MachineAddress : BaseApiBean
    {
        [XmlElement("address")]
        public string? Address { get; set; }

        [XmlArray("services")]
        [XmlArrayItem("service")]
        public List<MachineService>? MachineServices { get; set; }

        [XmlElement("type")]
        public AddressType Type { get; set; }
    }
}