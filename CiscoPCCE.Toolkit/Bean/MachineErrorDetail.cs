using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("errorDetail")]
    public class MachineErrorDetail : BaseApiBean
    {
        [XmlElement("machineName")]
        public string? MachineName { get; set; }

        [XmlElement("machineType")]
        public MachineType MachineType { get; set; }

        [XmlElement("side")]
        public string? Side { get; set; }
    }
}