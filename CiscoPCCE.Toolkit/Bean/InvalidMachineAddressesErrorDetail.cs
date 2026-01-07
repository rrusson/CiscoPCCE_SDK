using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("machineinventory")
    [XmlRoot("errorDetail")]
    public class InvalidMachineAddressesErrorDetail : BaseApiBean
    {
        [XmlElement("networksFound")]
        [XmlElement("network")]
        public List<MachineAddress>? NetworksFound { get; set; }

        [XmlElement("networksRequired")]
        [XmlElement("network")]
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