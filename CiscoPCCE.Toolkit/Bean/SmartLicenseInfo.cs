using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("smartlicenseinfo")]
    public class SmartLicenseInfo : BaseApiBean
    {
        [XmlElement("authorizationExpires")]
        public DateTime? AuthorizationExpires { get; set; }

        [XmlElement("authorizationFailedReason")]
        public string? AuthorizationFailedReason { get; set; }

        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("cssmAuthorizationStatus")]
        public int? CssmAuthorizationStatus { get; set; }

        [XmlElement("cssmRegistrationStatus")]
        public int? CssmRegistrationStatus { get; set; }

        [XmlElement("daysLeftInEvaluationMode")]
        public int? DaysLeftInEvaluationMode { get; set; }

        [XmlElement("daysLeftInOutOfCompliance")]
        public int? DaysLeftInOutOfCompliance { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("evaluationExpiredTime")]
        public DateTime? EvaluationExpiredTime { get; set; }

        [XmlElement("exportControlledAllow")]
        public bool? ExportControlledAllow { get; set; }

        [XmlElement("futureUseDateTime1")]
        public DateTime? FutureUseDateTime1 { get; set; }

        [XmlElement("futureUseInt6")]
        public int? FutureUseInt6 { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("isAuthorizationFailed")]
        public bool? IsAuthorizationFailed { get; set; }

        [XmlElement("isRegistrationFailed")]
        public bool? IsRegistrationFailed { get; set; }

        [XmlElement("lastAuthorizationAttempt")]
        public DateTime? LastAuthorizationAttempt { get; set; }

        [XmlElement("lastRenewalAttempt")]
        public DateTime? LastRenewalAttempt { get; set; }

        [XmlElement("nextAuthorizationAttempt")]
        public DateTime? NextAuthorizationAttempt { get; set; }

        [XmlElement("nextRenewalAttempt")]
        public DateTime? NextRenewalAttempt { get; set; }

        [XmlElement("overageDays")]
        public int? OverageDays { get; set; }

        [XmlElement("overageDaysUpdatedTime")]
        public DateTime? OverageDaysUpdatedTime { get; set; }

        [XmlElement("productDisplayName")]
        public string? ProductDisplayName { get; set; }

        [XmlElement("productInstance")]
        public string? ProductInstance { get; set; }

        [XmlElement("registrationExpires")]
        public DateTime? RegistrationExpires { get; set; }

        [XmlElement("registrationFailedReason")]
        public string? RegistrationFailedReason { get; set; }

        [XmlElement("smartAccount")]
        public string? SmartAccount { get; set; }

        [XmlElement("smartLicenseInfoID")]
        public int? SmartLicenseInfoID { get; set; }

        [XmlElement("smartLicenseServerId")]
        public int? SmartLicenseServerId { get; set; }

        [XmlElement("timeZoneName")]
        public string? TimeZoneName { get; set; }

        [XmlElement("virtualAccount")]
        public string? VirtualAccount { get; set; }
    }
}