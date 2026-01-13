using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("machineinventory")
    [XmlRoot("results")]
    public class InvalidMachineAddressesErrorDetailList : BaseApiList<InvalidMachineAddressesErrorDetail>
    {
        [XmlArray("errorDetails")]
        [XmlArrayItem("errorDetail")]
        public new List<InvalidMachineAddressesErrorDetail>? Items
        {
            get => base.Items;
            set => base.Items = value;
        }
    }
}