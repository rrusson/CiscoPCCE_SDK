using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("errorDetail")]
    public class CuicAwMachineCountMismatchErrorDetail : BaseApiBean
    {
        [XmlElement("awMachineCount")]
        public int? AwMachineCount { get; set; }

        [XmlElement("cuicMachineCount")]
        public int? CuicMachineCount { get; set; }
    }
}