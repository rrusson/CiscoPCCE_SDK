using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("machineinventory")
    [XmlRoot("address")]
    public class MachineAddress : BaseApiBean
    {
        public string? Address { get; set; }

        [XmlElement("services")]
        [XmlElement("service")]
        public List<MachineService>? MachineServices { get; set; }

        public AddressType Type { get; set; }

        // Path("machineinventory")
        [XmlRoot("results")]
        public class MachineAddressList : BaseApiListBean<MachineAddress>
        {
            public override List<MachineAddress>? GetItems() => Items;

            public override void SetItems(List<MachineAddress>? value) => Items = value;
        }
    }
}