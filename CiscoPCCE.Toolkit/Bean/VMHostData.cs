using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("vmHostData")]
    public class VMHostData : BaseApiBean
    {
        public string? Bios { get; set; }

        public short? CpuCores { get; set; }

        public string? CpuFamily { get; set; }

        public short? CpuReservationPercentage { get; set; }

        public double CpuSpeed { get; set; }

        public short? CpuSubscriptionPercentage { get; set; }

        [XmlElement("dataStores")]
        [XmlElement("dataStore")]
        public List<VMDatastoreData>? Datastores { get; set; }

        public double HardDiskUsage { get; set; }

        public long? MemoryMB { get; set; }

        public double ProcessorFrequency { get; set; }

        public short RamReservation { get; set; }

        [XmlElement("serverProfile")]
        public required VMHostProfile ServerProfile { get; set; }

        [XmlElement("version")]
        public string? ServerVersion { get; set; }

        public long TotalCapacity { get; set; }

        public string? Vendor { get; set; }
    }
}