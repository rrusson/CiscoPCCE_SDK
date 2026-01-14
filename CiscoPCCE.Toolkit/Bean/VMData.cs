using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("vmStatus")]
    public class VMData : BaseApiBean
    {
        public List<VMDatastoreData>? ActualDatastores { get; set; }

        [XmlElement("cores")]
        public int? Cores { get; set; }

        [XmlElement("cpuReservation")]
        public long? CpuReservation { get; set; }

        [XmlArray("disks")]
        [XmlArrayItem("disk")]
        public List<long?>? DiskSizesInGB { get; set; }

        [XmlElement("expectedDatastore")]
        public required VMDatastore ExpectedDatastore { get; set; }

        [XmlElement("guestOS")]
        public string? GuestOS { get; set; }

        [XmlElement("hostName")]
        public string? HostName { get; set; }

        [XmlElement("instanceId")]
        public string? InstanceId { get; set; }

        [XmlElement("memoryInMB")]
        public int? MemoryInMB { get; set; }

        [XmlElement("memoryReservation")]
        public int? MemoryReservation { get; set; }

        [XmlElement("numberOfAddresses")]
        public int? NumberOfAddresses { get; set; }

        [XmlElement("os")]
        public string? Os { get; set; }

        [XmlElement("poweredOn")]
        public bool? PoweredOn { get; set; }

        [XmlElement("profile")]
        public required VMProfile Profile { get; set; }

        [XmlElement("profileName")]
        public string? ProfileName { get; set; }

        [XmlElement("videoMemory")]
        public int? VideoMemory { get; set; }

        [XmlArray("addresses")]
        [XmlArrayItem("address")]
        public List<VMAddress>? VmAddresses { get; set; }

        [XmlElement("vmAnnotation")]
        public string? VmAnnotation { get; set; }

        [XmlElement("vmName")]
        public string? VmName { get; set; }

        [XmlElement("vmToolsVersion")]
        public string? VmToolsVersion { get; set; }

        [XmlElement("vmwareToolsUpToDate")]
        public bool? VmwareToolsUpToDate { get; set; }
    }
}