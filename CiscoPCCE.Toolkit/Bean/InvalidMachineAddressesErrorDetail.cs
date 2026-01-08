using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("machineinventory")
    [XmlRoot("errorDetail")]
    public class InvalidMachineAddressesErrorDetail : BaseApiBean
    {
        [XmlArray("networksFound")]
        [XmlArrayItem("network")]
        public List<MachineAddress>? NetworksFound { get; set; }

        [XmlArray("networksRequired")]
        [XmlArrayItem("network")]
        public List<MachineAddress>? NetworksRequired { get; set; }

        // Path("machineinventory")
        [XmlRoot("results")]
        public class InvalidMachineAddressesErrorDetailList : BaseApiListBean<InvalidMachineAddressesErrorDetail>
        {
            public override List<InvalidMachineAddressesErrorDetail>? GetItems() => Items;

            public override void SetItems(List<InvalidMachineAddressesErrorDetail>? value) => Items = value;
        }
    }
}