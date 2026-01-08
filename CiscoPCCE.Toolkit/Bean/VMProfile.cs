using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    public class VMProfile : BaseApiBean
    {
        [XmlElement("cores")]
        public int Cores { get; set; }

        [XmlElement("cpuReservation")]
        public long CpuReservation { get; set; }

        [XmlArray("disks")]
        [XmlArrayItem("disk")]
        public List<long?>? DiskSizesInGB { get; set; }

        [XmlElement("machineType")]
        public string? MachineType { get; set; }

        [XmlElement("memoryInMB")]
        public int MemoryInMB { get; set; }

        [XmlElement("memoryReservation")]
        public int? MemoryReservation { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("networkType")]
        public string? NetworkType { get; set; }

        [XmlElement("numberOfAddresses")]
        public int? NumberOfAddresses { get; set; }

        [XmlElement("os")]
        public string? Os { get; set; }

        [XmlElement("required")]
        public bool? Required { get; set; }

        [XmlElement("videoMemory")]
        public int? VideoMemory { get; set; }
    }
}