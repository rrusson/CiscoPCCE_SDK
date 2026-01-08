using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("errorDetail")]
    public class DuplexedMachineErrorDetail : BaseApiBean
    {
        public List<MachineType>? MachineTypes { get; set; }

        [XmlElement("periperhalSetName")]
        public string? PeriperhalSetName { get; set; }
    }
}