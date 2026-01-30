using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("smartLicenseInfo")]
    public class CvpSmartLicenseInfo : BaseApiBean
    {
        [XmlElement("authorizationExpires")]
        public string? AuthorizationExpires { get; set; }

        [XmlElement("authorizationFailed")]
        public bool? AuthorizationFailed { get; set; }

        [XmlElement("authorizationFailedReason")]
        public string? AuthorizationFailedReason { get; set; }

        [XmlElement("cssmAuthorizationStatus")]
        public int? CssmAuthorizationStatus { get; set; }

        [XmlElement("cssmRegistrationStatus")]
        public int? CssmRegistrationStatus { get; set; }

        [XmlElement("daysLeftInEvaluationMode")]
        public int? DaysLeftInEvaluationMode { get; set; }

        [XmlElement("daysLeftInOutOfCompliance")]
        public int? DaysLeftInOutOfCompliance { get; set; }

        [XmlElement("evaluationExpiredTime")]
        public string? EvaluationExpiredTime { get; set; }

        [XmlElement("exportControlledAllow")]
        public bool? ExportControlledAllow { get; set; }

        [XmlElement("inEnforcement")]
        public bool? InEnforcement { get; set; }

        [XmlElement("lastAuthorizationAttempt")]
        public string? LastAuthorizationAttempt { get; set; }

        [XmlElement("lastRenewalAttempt")]
        public string? LastRenewalAttempt { get; set; }

        [XmlElement("nextAuthorizationAttempt")]
        public string? NextAuthorizationAttempt { get; set; }

        [XmlElement("nextRenewalAttempt")]
        public string? NextRenewalAttempt { get; set; }

        [XmlElement("outOfComplianceCount")]
        public int? OutOfComplianceCount { get; set; }

        [XmlElement("outOfComplianceTime")]
        public string? OutOfComplianceTime { get; set; }

        [XmlElement("overageDays")]
        public int? OverageDays { get; set; }

        [XmlElement("overageDaysUpdatedTime")]
        public string? OverageDaysUpdatedTime { get; set; }

        [XmlElement("productInstanceName")]
        public string? ProductInstanceName { get; set; }

        [XmlElement("registrationExpires")]
        public string? RegistrationExpires { get; set; }

        [XmlElement("registrationFailed")]
        public bool? RegistrationFailed { get; set; }

        [XmlElement("registrationFailedReason")]
        public string? RegistrationFailedReason { get; set; }

        [XmlElement("smartAccountName")]
        public string? SmartAccountName { get; set; }

        [XmlElement("smartLicenseInfoId")]
        public int? SmartLicenseInfoId { get; set; }

        [XmlElement("smartLicenseServerId")]
        public int? SmartLicenseServerId { get; set; }

        [XmlElement("virtualAccountName")]
        public string? VirtualAccountName { get; set; }
    }
}