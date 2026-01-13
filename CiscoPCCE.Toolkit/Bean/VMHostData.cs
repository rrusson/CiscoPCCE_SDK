using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("vmHostData")]
    public class VMHostData : BaseApiBean
    {
        [XmlElement("bios")]
        public string? Bios { get; set; }

        [XmlElement("cpuCores")]
        public short? CpuCores { get; set; }

        [XmlElement("cpuFamily")]
        public string? CpuFamily { get; set; }

        [XmlElement("cpuReservationPercentage")]
        public short? CpuReservationPercentage { get; set; }

        [XmlElement("cpuSpeed")]
        public double CpuSpeed { get; set; }

        [XmlElement("cpuSubscriptionPercentage")]
        public short? CpuSubscriptionPercentage { get; set; }

        [XmlArray("dataStores")]
        [XmlArrayItem("dataStore")]
        public List<VMDatastoreData>? Datastores { get; set; }

        [XmlElement("hardDiskUsage")]
        public double HardDiskUsage { get; set; }

        [XmlElement("memoryMB")]
        public long? MemoryMB { get; set; }

        [XmlElement("processorFrequency")]
        public double ProcessorFrequency { get; set; }

        [XmlElement("ramReservation")]
        public short RamReservation { get; set; }

        [XmlElement("serverProfile")]
        public required VMHostProfile ServerProfile { get; set; }

        [XmlElement("version")]
        public string? ServerVersion { get; set; }

        [XmlElement("totalCapacity")]
        public long TotalCapacity { get; set; }

        [XmlElement("vendor")]
        public string? Vendor { get; set; }
    }
}