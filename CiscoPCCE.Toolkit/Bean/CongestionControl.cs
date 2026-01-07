using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("congestioncontrol")
    [XmlRoot("congestionControl")]
    public class CongestionControl : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public bool? CongestionEnabled { get; set; }

        public int? CongestionTreatmentMode { get; set; }

        public string? CorrelationId { get; set; }

        public int? CpsCapacity { get; set; }

        public int? CpsCapacityDefault { get; set; }

        public required ReferenceBean Department { get; set; }

        public int? DeploymentType { get; set; }

        public string? IdFromRefUrl { get; set; }

        public required CongestionControlPermissionInfo PermissionInfo { get; set; }

        public string? SystemDefaultLabel { get; set; }

        // Path("congestioncontrol")
        [XmlRoot("results")]
        public class CongestionControlList : BaseApiListBean<CongestionControl>
        {
            public override List<CongestionControl>? GetItems() => Items;

            public override void SetItems(List<CongestionControl>? value) => Items = value;
        }
    }
}