using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("errorDetail")]
    public class MachineTypeNumberOutOfRangeErrorDetail : BaseApiBean
    {
        [XmlElement("actual")]
        public int? Actual { get; set; }

        public List<MachineType>? MachineTypes { get; set; }

        [XmlElement("max")]
        public int? Max { get; set; }

        [XmlElement("min")]
        public int? Min { get; set; }

        [XmlElement("peripheralSetName")]
        public string? PeripheralSetName { get; set; }
    }
}