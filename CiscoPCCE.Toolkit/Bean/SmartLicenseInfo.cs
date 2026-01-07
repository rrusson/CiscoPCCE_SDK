using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("smartlicense")
    [XmlRoot("smartlicenseinfo")]
    public class SmartLicenseInfo : BaseApiBean
    {
        public DateTime? AuthorizationExpires { get; set; }

        public string? AuthorizationFailedReason { get; set; }

        public string? BaseUrlfromRefUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public int? CssmAuthorizationStatus { get; set; }

        public int? CssmRegistrationStatus { get; set; }

        public int? DaysLeftInEvaluationMode { get; set; }

        public int? DaysLeftInOutOfCompliance { get; set; }

        public required ReferenceBean Department { get; set; }

        public DateTime? EvaluationExpiredTime { get; set; }

        public bool? ExportControlledAllow { get; set; }

        public DateTime? FutureUseDateTime1 { get; set; }

        public int? FutureUseInt6 { get; set; }

        public string? IdFromRefUrl { get; set; }

        public bool? IsAuthorizationFailed { get; set; }

        public bool? IsRegistrationFailed { get; set; }

        public DateTime? LastAuthorizationAttempt { get; set; }

        public DateTime? LastRenewalAttempt { get; set; }

        public DateTime? NextAuthorizationAttempt { get; set; }

        public DateTime? NextRenewalAttempt { get; set; }

        public int? OverageDays { get; set; }

        public DateTime? OverageDaysUpdatedTime { get; set; }

        public string? ProductDisplayName { get; set; }

        public string? ProductInstance { get; set; }

        public new string? RefURL { get; set; }

        public DateTime? RegistrationExpires { get; set; }

        public string? RegistrationFailedReason { get; set; }

        public string? SmartAccount { get; set; }

        public int? SmartLicenseInfoID { get; set; }

        public int? SmartLicenseServerId { get; set; }

        public string? TimeZoneName { get; set; }

        public string? VirtualAccount { get; set; }

        // Path("smartlicense")
        [XmlRoot("results")]
        public class SmartLicenseInfoList : BaseApiListBean<SmartLicenseInfo>
        {
            public override List<SmartLicenseInfo>? GetItems() => Items;

            public override void SetItems(List<SmartLicenseInfo>? value) => Items = value;
        }
    }
}