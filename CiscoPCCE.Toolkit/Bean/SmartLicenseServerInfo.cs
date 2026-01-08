using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    // Path("smartlicense")
    [XmlRoot("smartlicenseserverinfo")]
    public class SmartLicenseServerInfo : BaseApiBean
    {
        [XmlElement("agentId")]
        public string? AgentId { get; set; }

        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("callHomeUrl")]
        public string? CallHomeUrl { get; set; }

        [XmlElement("changeStamp")]
        public new int? ChangeStamp { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("cssmResponseTimeout")]
        public int? CssmResponseTimeout { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("deploymentMode")]
        public int? DeploymentMode { get; set; }

        [XmlElement("excludeSpikes")]
        public bool? ExcludeSpikes { get; set; }

        [XmlElement("force")]
        public bool? Force { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("idToken")]
        public string? IdToken { get; set; }

        [XmlElement("licenseType")]
        public int? LicenseType { get; set; }

        [XmlElement("outOfCompliance")]
        public bool? OutOfCompliance { get; set; }

        [XmlElement("outOfComplianceCount")]
        public int? OutOfComplianceCount { get; set; }

        [XmlElement("outOfComplianceStartTime")]
        public DateTime? OutOfComplianceStartTime { get; set; }

        [XmlElement("proxyHostnameOrIP")]
        public string? ProxyHostnameOrIP { get; set; }

        [XmlElement("proxyPort")]
        public int? ProxyPort { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("reservationStatus")]
        public string? ReservationStatus { get; set; }

        [XmlElement("reservationType")]
        public ReservationType ReservationType { get; set; }

        [XmlElement("serialNumber")]
        public string? SerialNumber { get; set; }

        [XmlElement("smartCode")]
        public string? SmartCode { get; set; }

        [XmlElement("smartLicenseServerID")]
        public int? SmartLicenseServerID { get; set; }

        [XmlElement("smartTransportUrl")]
        public string? SmartTransportUrl { get; set; }

        [XmlElement("transportGatewayUrl")]
        public string? TransportGatewayUrl { get; set; }

        [XmlElement("transportMode")]
        public int? TransportMode { get; set; }

        [XmlElement("transportType")]
        public int? TransportType { get; set; }

        [XmlElement("transportUrl")]
        public string? TransportUrl { get; set; }

        [XmlElement("usageMode")]
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