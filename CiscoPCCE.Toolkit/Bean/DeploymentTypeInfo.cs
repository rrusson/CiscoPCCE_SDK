using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("deploymenttypeinfo")
    [XmlRoot("deploymentTypeInfo")]
    public class DeploymentTypeInfo : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public required CapacityInfo CapacityInfo { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public int? DeploymentType { get; set; }

        public HardwareLayoutType HardwareLayoutType { get; set; }

        public string? IdFromRefUrl { get; set; }

        public bool? InventoryConfigured { get; set; }

        public required PermissionInfo PermissionInfo { get; set; }

        public required SystemValidationStatus SystemValidationStatus { get; set; }

        public int? TargetDeploymentType { get; set; }

        [XmlElement("vmHosts")]
        [XmlElement("vmHost")]
        public List<VMHost>? VmHosts { get; set; }

        public string? VmLayoutType { get; set; }

        public string? VmValidationLogURL { get; set; }

        // Path("deploymenttypeinfo")
        [XmlRoot("results")]
        public class DeploymentTypeInfoList : BaseApiListBean<DeploymentTypeInfo>
        {
            public override List<DeploymentTypeInfo>? GetItems() => Items;

            public override void SetItems(List<DeploymentTypeInfo>? value) => Items = value;
        }
    }
}