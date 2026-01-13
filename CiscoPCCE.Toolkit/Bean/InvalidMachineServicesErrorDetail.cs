using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("machineinventory")
    [XmlRoot("errorDetail")]
    public class InvalidMachineServicesErrorDetail : BaseApiBean
    {
        [XmlArray("servicesFound")]
        [XmlArrayItem("service")]
        public List<MachineService>? ServicesFound { get; set; }

        [XmlArray("servicesRequired")]
        [XmlArrayItem("service")]
        public List<MachineService>? ServicesRequired { get; set; }
    }
}