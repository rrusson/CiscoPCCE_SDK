using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("smartlicense")
    [XmlRoot("smartlicenseentitlement")]
    public class SmartLicenseEntitlement : BaseApiBean
    {
        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Department { get; set; }

        public string? DeploymentType { get; set; }

        public string? EnforceMode { get; set; }

        public string? EntitlementDescription { get; set; }

        public string? EntitlementDisplayname { get; set; }

        public string? EntitlementTag { get; set; }

        public string? EntitlementVersion { get; set; }

        public string? IdFromRefUrl { get; set; }

        public int? LicenseType { get; set; }

        public int? LockUsage { get; set; }

        public int? OutOfCompliance { get; set; }

        public int? OutOfComplianceCount { get; set; }

        public int? PeakUsage { get; set; }

        public new string? RefURL { get; set; }

        public int? SmartLicenseEntitlementsTagID { get; set; }

        // Path("smartlicense")
        [XmlRoot("results")]
        public class SmartLicenseEntitlementList : BaseApiListBean<SmartLicenseEntitlement>
        {
            public override List<SmartLicenseEntitlement>? GetItems() => Items;

            public override void SetItems(List<SmartLicenseEntitlement>? value) => Items = value;
        }
    }
}