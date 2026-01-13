using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("serverStatus")]
    public class VMServerData : BaseApiBean
    {
        [XmlElement("biosValid")]
        public bool? BiosValid { get; set; }

        [XmlElement("cpuFamilyValid")]
        public bool? CpuFamilyValid { get; set; }

        [XmlElement("cpuReservationValid")]
        public bool? CpuReservationValid { get; set; }

        [XmlElement("cpuSpeedValid")]
        public bool? CpuSpeedValid { get; set; }

        [XmlElement("cpuSubscriptionValid")]
        public bool? CpuSubscriptionValid { get; set; }

        [XmlElement("dataStoresValid")]
        public bool? DataStoresValid { get; set; }

        [XmlElement("id")]
        public string? Id { get; set; }

        [XmlElement("memoryReservationValid")]
        public bool? MemoryReservationValid { get; set; }

        [XmlArray("optionalProfilesNotMatched")]
        [XmlArrayItem("profile")]
        public List<VMData>? OptionalProfilesNotMatched { get; set; }

        [XmlElement("propertiesValid")]
        public bool? PropertiesValid { get; set; }

        [XmlArray("requiredProfilesNotMatched")]
        [XmlArrayItem("profile")]
        public List<VMData>? RequiredProfilesNotMatched { get; set; }

        [XmlElement("vMHost")]
        public required VMHost VMHost { get; set; }

        [XmlElement("vMHostData")]
        public required VMHostData VMHostData { get; set; }

        [XmlElement("vmLayoutValid")]
        public bool? VmLayoutValid { get; set; }

        [XmlArray("vmsDuplicated")]
        [XmlArrayItem("vm")]
        public List<VMData>? VmsDuplicated { get; set; }

        [XmlArray("vmsMatched")]
        [XmlArrayItem("vm")]
        public List<VMData>? VmsMatched { get; set; }

        [XmlArray("vmsNotMatched")]
        [XmlArrayItem("vm")]
        public List<VMData>? VmsNotMatched { get; set; }
    }
}