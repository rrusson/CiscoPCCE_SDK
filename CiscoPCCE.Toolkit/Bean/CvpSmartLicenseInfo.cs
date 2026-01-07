using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("smartLicenseInfo")]
    public class CvpSmartLicenseInfo : BaseApiBean
    {
        public string? AuthorizationExpires { get; set; }

        public bool? AuthorizationFailed { get; set; }

        public string? AuthorizationFailedReason { get; set; }

        public int? CssmAuthorizationStatus { get; set; }

        public int? CssmRegistrationStatus { get; set; }

        public int? DaysLeftInEvaluationMode { get; set; }

        public int? DaysLeftInOutOfCompliance { get; set; }

        public string? EvaluationExpiredTime { get; set; }

        public bool? ExportControlledAllow { get; set; }

        public bool? InEnforcement { get; set; }

        public string? LastAuthorizationAttempt { get; set; }

        public string? LastRenewalAttempt { get; set; }

        public string? NextAuthorizationAttempt { get; set; }

        public string? NextRenewalAttempt { get; set; }

        public int? OutOfComplianceCount { get; set; }

        public string? OutOfComplianceTime { get; set; }

        public int? OverageDays { get; set; }

        public string? OverageDaysUpdatedTime { get; set; }

        public string? ProductInstanceName { get; set; }

        public string? RegistrationExpires { get; set; }

        public bool? RegistrationFailed { get; set; }

        public string? RegistrationFailedReason { get; set; }

        public string? SmartAccountName { get; set; }

        public int? SmartLicenseInfoId { get; set; }

        public int? SmartLicenseServerId { get; set; }

        public string? VirtualAccountName { get; set; }
    }
}