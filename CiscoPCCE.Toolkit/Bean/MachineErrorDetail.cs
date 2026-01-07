using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("errorDetail")]
    public class MachineErrorDetail : BaseApiBean
    {
        public string? MachineName { get; set; }

        public MachineType MachineType { get; set; }

        public string? Side { get; set; }
    }
}