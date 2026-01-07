using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("vmStatus")]
    public class VMData : BaseApiBean
    {
        public List<VMDatastoreData>? ActualDatastores { get; set; }

        public int? Cores { get; set; }

        public long? CpuReservation { get; set; }

        [XmlElement("disks")]
        [XmlElement("disk")]
        public List<long?>? DiskSizesInGB { get; set; }

        public required VMDatastore ExpectedDatastore { get; set; }

        public string? GuestOS { get; set; }

        public string? HostName { get; set; }

        public string? InstanceId { get; set; }

        public int? MemoryInMB { get; set; }

        public int? MemoryReservation { get; set; }

        public int? NumberOfAddresses { get; set; }

        public string? Os { get; set; }

        public bool? PoweredOn { get; set; }

        public required VMProfile Profile { get; set; }

        public string? ProfileName { get; set; }

        public int? VideoMemory { get; set; }

        [XmlElement("addresses")]
        [XmlElement("address")]
        public List<VMAddress>? VmAddresses { get; set; }

        public string? VmAnnotation { get; set; }

        public string? VmName { get; set; }

        public string? VmToolsVersion { get; set; }

        public bool? VmwareToolsUpToDate { get; set; }
    }
}