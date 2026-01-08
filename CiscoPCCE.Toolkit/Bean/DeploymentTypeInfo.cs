using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("deploymenttypeinfo")
    [XmlRoot("deploymentTypeInfo")]
    public class DeploymentTypeInfo : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("capacityInfo")]
        public required CapacityInfo CapacityInfo { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

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

        // Path("deploymenttypeinfo")
        [XmlRoot("results")]
        public class DeploymentTypeInfoList : BaseApiListBean<DeploymentTypeInfo>
        {
            [XmlArray("deploymentTypeInfos")]
            [XmlArrayItem("deploymentTypeInfo")]
            public new List<DeploymentTypeInfo>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<DeploymentTypeInfo>? GetItems() => Items;

            public override void SetItems(List<DeploymentTypeInfo>? value) => Items = value;
        }
    }
}