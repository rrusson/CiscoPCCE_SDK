using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

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
            [XmlArray("errorDetails")]
            [XmlArrayItem("errorDetail")]
            public new List<InvalidMachineAddressesErrorDetail>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<InvalidMachineAddressesErrorDetail>? GetItems() => Items;

            public override void SetItems(List<InvalidMachineAddressesErrorDetail>? value) => Items = value;
        }
    }
}