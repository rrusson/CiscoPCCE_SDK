using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("serviceability")]
    public class Serviceability : BaseApiBean
    {
        [XmlElement("apiStats")]
        public required ApiStats ApiStats { get; set; }

        [XmlElement("capacityInfo")]
        public required CapacityInfo CapacityInfo { get; set; }

        [XmlElement("deploymentTaskStats")]
        public required DeploymentTaskStats DeploymentTaskStats { get; set; }

        [XmlElement("jvmStats")]
        public required JvmStats JvmStats { get; set; }

        [XmlElement("systemInfo")]
        public required SystemInfo SystemInfo { get; set; }

        [XmlElement("systemInfoSummary")]
        public required SystemInfo SystemInfoSummary { get; set; }

        [XmlElement("systemValidationStatus")]
        public required SystemValidationStatus SystemValidationStatus { get; set; }

        [XmlElement("taskStats")]
        public required TaskStats TaskStats { get; set; }

        [XmlElement("ucceVersion")]
        public required UcceVersion UcceVersion { get; set; }

        [XmlElement("version")]
        public required VersionBase Version { get; set; }
    }
}