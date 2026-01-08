using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("errorDetail")]
    public class MachineListErrorDetail : BaseApiBean
    {
        [XmlElement("errorType")]
        public string? ErrorType { get; set; }

        [XmlElement("machines")]
        [XmlElement("machine")]
        public required Set Machines { get; set; }
    }
}