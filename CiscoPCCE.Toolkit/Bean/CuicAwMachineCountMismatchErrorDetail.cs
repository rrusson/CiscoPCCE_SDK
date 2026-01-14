using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("errorDetail")]
    public class CuicAwMachineCountMismatchErrorDetail : BaseApiBean
    {
        [XmlElement("awMachineCount")]
        public int? AwMachineCount { get; set; }

        [XmlElement("cuicMachineCount")]
        public int? CuicMachineCount { get; set; }
    }
}