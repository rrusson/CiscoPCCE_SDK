using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("smartlicense")
    [XmlRoot("smartlicenseserverinfo")]
    public class SmartLicenseServerInfo : BaseApiBean
    {
        public string? AgentId { get; set; }

        public string? BaseUrlfromRefUrl { get; set; }

        public string? CallHomeUrl { get; set; }

        public new int? ChangeStamp { get; set; }

        public string? CorrelationId { get; set; }

        public int? CssmResponseTimeout { get; set; }

        public required ReferenceBean Department { get; set; }

        public int? DeploymentMode { get; set; }

        public bool? ExcludeSpikes { get; set; }

        public bool? Force { get; set; }

        public string? IdFromRefUrl { get; set; }

        public string? IdToken { get; set; }

        public int? LicenseType { get; set; }

        public bool? OutOfCompliance { get; set; }

        public int? OutOfComplianceCount { get; set; }

        public DateTime? OutOfComplianceStartTime { get; set; }

        public string? ProxyHostnameOrIP { get; set; }

        public int? ProxyPort { get; set; }

        public new string? RefURL { get; set; }

        public string? ReservationStatus { get; set; }

        public ReservationType ReservationType { get; set; }

        public string? SerialNumber { get; set; }

        public string? SmartCode { get; set; }

        public int? SmartLicenseServerID { get; set; }

        public string? SmartTransportUrl { get; set; }

        public string? TransportGatewayUrl { get; set; }

        public int? TransportMode { get; set; }

        public int? TransportType { get; set; }

        public string? TransportUrl { get; set; }

        public int? UsageMode { get; set; }

        // Path("smartlicense")
        [XmlRoot("results")]
        public class SmartLicenseServerInfoList : BaseApiListBean<SmartLicenseServerInfo>
        {
            public override List<SmartLicenseServerInfo>? GetItems() => Items;

            public override void SetItems(List<SmartLicenseServerInfo>? value) => Items = value;
        }
    }
}