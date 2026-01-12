using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("congestioncontrol")
    [XmlRoot("congestionControl")]
    public class CongestionControl : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("congestionEnabled")]
        public bool? CongestionEnabled { get; set; }

        [XmlElement("congestionTreatmentMode")]
        public int? CongestionTreatmentMode { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("cpsCapacity")]
        public int? CpsCapacity { get; set; }

        [XmlElement("cpsCapacityDefault")]
        public int? CpsCapacityDefault { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("deploymentType")]
        public int? DeploymentType { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("permissionInfo")]
        public required CongestionControlPermissionInfo PermissionInfo { get; set; }

        [XmlElement("systemDefaultLabel")]
        public string? SystemDefaultLabel { get; set; }
        
    }
}