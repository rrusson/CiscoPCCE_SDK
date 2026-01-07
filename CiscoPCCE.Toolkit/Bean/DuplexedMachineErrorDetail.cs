using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("errorDetail")]
    public class DuplexedMachineErrorDetail : BaseApiBean
    {
        public List<MachineType>? MachineTypes { get; set; }

        public string? PeriperhalSetName { get; set; }
    }
}