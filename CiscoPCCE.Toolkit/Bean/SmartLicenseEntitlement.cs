using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("smartlicense")
    [XmlRoot("smartlicenseentitlement")]
    public class SmartLicenseEntitlement : BaseApiBean
    {
        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("deploymentType")]
        public string? DeploymentType { get; set; }

        [XmlElement("enforceMode")]
        public string? EnforceMode { get; set; }

        [XmlElement("entitlementDescription")]
        public string? EntitlementDescription { get; set; }

        [XmlElement("entitlementDisplayname")]
        public string? EntitlementDisplayname { get; set; }

        [XmlElement("entitlementTag")]
        public string? EntitlementTag { get; set; }

        [XmlElement("entitlementVersion")]
        public string? EntitlementVersion { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("licenseType")]
        public int? LicenseType { get; set; }

        [XmlElement("lockUsage")]
        public int? LockUsage { get; set; }

        [XmlElement("outOfCompliance")]
        public int? OutOfCompliance { get; set; }

        [XmlElement("outOfComplianceCount")]
        public int? OutOfComplianceCount { get; set; }

        [XmlElement("peakUsage")]
        public int? PeakUsage { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("smartLicenseEntitlementsTagID")]
        public int? SmartLicenseEntitlementsTagID { get; set; }

        // Path("smartlicense")
        [XmlRoot("results")]
        public class SmartLicenseEntitlementList : BaseApiListBean<SmartLicenseEntitlement>
        {
            [XmlArray("smartlicenseentitlements")]
            [XmlArrayItem("smartlicenseentitlement")]
            public new List<SmartLicenseEntitlement>? Items
            {
                get => base.Items;
                set => base.Items = value;
            }

            public override List<SmartLicenseEntitlement>? GetItems() => Items;

            public override void SetItems(List<SmartLicenseEntitlement>? value) => Items = value;
        }
    }
}