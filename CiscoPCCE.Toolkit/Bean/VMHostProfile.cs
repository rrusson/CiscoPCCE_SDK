using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class VMHostProfile : BaseApiBean
    {
        [XmlElement("biosVersion")]
        public string? BiosVersion { get; set; }

        [XmlElement("cpuFamily")]
        public string? CpuFamily { get; set; }

        [XmlArray("dataStores")]
        [XmlArrayItem("dataStore")]
        public List<VMDatastore>? Datastores { get; set; }

        [XmlElement("hardwareLayoutType")]
        public string? HardwareLayoutType { get; set; }

        [XmlElement("maxCpuOverSubscription")]
        public short MaxCpuOverSubscription { get; set; }

        [XmlElement("maxCpuReservation")]
        public short MaxCpuReservation { get; set; }

        [XmlElement("maxMemoryReservation")]
        public short MaxMemoryReservation { get; set; }

        [XmlElement("maxStorageUsagePerDatastore")]
        public double MaxStorageUsagePerDatastore { get; set; }

        [XmlElement("minCpuCores")]
        public short MinCpuCores { get; set; }

        [XmlElement("minCpuSpeed")]
        public double MinCpuSpeed { get; set; }

        [XmlElement("minimumMemoryMB")]
        public long MinimumMemoryMB { get; set; }

        [XmlArray("supportedServerVersions")]
        [XmlArrayItem("version")]
        public List<string?>? SupportedServerVersions { get; set; }

        [XmlElement("vendor")]
        public string? Vendor { get; set; }

        [XmlArray("vmsToMatch")]
        [XmlArrayItem("vm")]
        public List<VMProfile>? VmsToMatch { get; set; }
    }
}