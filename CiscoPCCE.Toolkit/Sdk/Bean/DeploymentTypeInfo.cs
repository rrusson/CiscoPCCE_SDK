using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("deploymentTypeInfo")]
    public class DeploymentTypeInfo : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("capacityInfo")]
        public required CapacityInfo CapacityInfo { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("deploymentType")]
        public int? DeploymentType { get; set; }

        [XmlElement("hardwareLayoutType")]
        public HardwareLayoutType HardwareLayoutType { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("inventoryConfigured")]
        public bool? InventoryConfigured { get; set; }

        [XmlElement("permissionInfo")]
        public required PermissionInfo PermissionInfo { get; set; }

        [XmlElement("systemValidationStatus")]
        public required SystemValidationStatus SystemValidationStatus { get; set; }

        [XmlElement("targetDeploymentType")]
        public int? TargetDeploymentType { get; set; }

        [XmlArray("vmHosts")]
        [XmlArrayItem("vmHost")]
        public List<VMHost>? VmHosts { get; set; }

        [XmlElement("vmLayoutType")]
        public string? VmLayoutType { get; set; }

        [XmlElement("vmValidationLogURL")]
        public string? VmValidationLogURL { get; set; }
    }
}