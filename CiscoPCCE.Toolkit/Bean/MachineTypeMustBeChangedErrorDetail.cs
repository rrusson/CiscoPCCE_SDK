using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("machineinventory")
    [XmlRoot("errorDetail")]
    public class MachineTypeMustBeChangedErrorDetail : BaseApiBean
    {
        [XmlElement("type")]
        public MachineType Type { get; set; }

        [XmlArray("validMachineTypes")]
        [XmlArrayItem("type")]
        public List<MachineType>? ValidMachineTypes { get; set; }
    }
}