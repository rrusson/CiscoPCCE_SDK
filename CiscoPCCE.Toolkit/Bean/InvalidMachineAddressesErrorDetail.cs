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
        
    }
}