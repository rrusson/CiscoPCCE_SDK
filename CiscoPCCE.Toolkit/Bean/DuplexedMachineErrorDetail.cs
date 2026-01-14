using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("errorDetail")]
    public class DuplexedMachineErrorDetail : BaseApiBean
    {
        public List<MachineType>? MachineTypes { get; set; }

        [XmlElement("periperhalSetName")]
        public string? PeriperhalSetName { get; set; }
    }
}