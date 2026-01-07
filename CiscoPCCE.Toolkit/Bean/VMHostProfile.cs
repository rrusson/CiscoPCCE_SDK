using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    public class VMHostProfile : BaseApiBean
    {
        public string? BiosVersion { get; set; }

        public string? CpuFamily { get; set; }

        [XmlElement("dataStores")]
        [XmlElement("dataStore")]
        public List<VMDatastore>? Datastores { get; set; }

        public string? HardwareLayoutType { get; set; }

        public short MaxCpuOverSubscription { get; set; }

        public short MaxCpuReservation { get; set; }

        public short MaxMemoryReservation { get; set; }

        public double MaxStorageUsagePerDatastore { get; set; }

        public short MinCpuCores { get; set; }

        public double MinCpuSpeed { get; set; }

        public long MinimumMemoryMB { get; set; }

        [XmlElement("supportedServerVersions")]
        [XmlElement("version")]
        public List<string?>? SupportedServerVersions { get; set; }

        public string? Vendor { get; set; }

        [XmlElement("vmsToMatch")]
        [XmlElement("vm")]
        public List<VMProfile>? VmsToMatch { get; set; }
    }
}