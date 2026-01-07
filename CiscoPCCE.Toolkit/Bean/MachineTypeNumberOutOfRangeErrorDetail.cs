using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("errorDetail")]
    public class MachineTypeNumberOutOfRangeErrorDetail : BaseApiBean
    {
        public int? Actual { get; set; }

        public List<MachineType>? MachineTypes { get; set; }

        public int? Max { get; set; }

        public int? Min { get; set; }

        public string? PeripheralSetName { get; set; }
    }
}