using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("serviceability")]
    public class Serviceability : BaseApiBean
    {
        public required ApiStats ApiStats { get; set; }

        public required CapacityInfo CapacityInfo { get; set; }

        public required DeploymentTaskStats DeploymentTaskStats { get; set; }

        public required JvmStats JvmStats { get; set; }

        public required SystemInfo SystemInfo { get; set; }

        [XmlElement("systemInfoSummary")]
        public required SystemInfo SystemInfoSummary { get; set; }

        [XmlElement("systemValidationStatus")]
        public required SystemValidationStatus SystemValidationStatus { get; set; }

        public required TaskStats TaskStats { get; set; }

        [XmlElement("ucceVersion")]
        public required UcceVersion UcceVersion { get; set; }

        public required VersionBase Version { get; set; }
    }
}