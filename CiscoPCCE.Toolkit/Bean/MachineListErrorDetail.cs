using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("errorDetail")]
    public class MachineListErrorDetail : BaseApiBean
    {
        [XmlElement("errorType")]
        public string? ErrorType { get; set; }

        [XmlElement("machines")]
        [XmlElement("machine")]
        public required Set Machines { get; set; }
    }
}