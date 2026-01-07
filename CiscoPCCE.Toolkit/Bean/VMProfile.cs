using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    public class VMProfile : BaseApiBean
    {
        public int Cores { get; set; }

        public long CpuReservation { get; set; }

        [XmlElement("disks")]
        [XmlElement("disk")]
        public List<long?>? DiskSizesInGB { get; set; }

        public string? MachineType { get; set; }

        public int MemoryInMB { get; set; }

        public int? MemoryReservation { get; set; }

        public string? Name { get; set; }

        public string? NetworkType { get; set; }

        public int? NumberOfAddresses { get; set; }

        public string? Os { get; set; }

        public bool? Required { get; set; }

        public int? VideoMemory { get; set; }
    }
}