using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("machineinventory")
    [XmlRoot("address")]
    public class MachineAddress : BaseApiBean
    {
        [XmlElement("address")]
        public string? Address { get; set; }

        [XmlArray("services")]
        [XmlArrayItem("service")]
        public List<MachineService>? MachineServices { get; set; }

        [XmlElement("type")]
        public AddressType Type { get; set; }

        // Path("machineinventory")
        [XmlRoot("results")]
        public class MachineAddressList : BaseApiListBean<MachineAddress>
        {
            [XmlArray("addresss")]
            [XmlArrayItem("address")]
            public new List<MachineAddress>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<MachineAddress>? GetItems() => Items;

            public override void SetItems(List<MachineAddress>? value) => Items = value;
        }
    }
}