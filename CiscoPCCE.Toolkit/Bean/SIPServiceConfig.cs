using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("sip")]
    public class SIPServiceConfig : BaseApiBean
    {
        [XmlElement("commaDuration")]
        public int? CommaDuration { get; set; }

        [XmlElement("enableOutboundProxy")]
        public bool? EnableOutboundProxy { get; set; }

        [XmlElement("incomingPort")]
        public int? IncomingPort { get; set; }

        [XmlElement("incomingSecurePort")]
        public int? IncomingSecurePort { get; set; }

        [XmlElement("outboundProxyHost")]
        public string? OutboundProxyHost { get; set; }

        [XmlElement("outboundProxyPort")]
        public int? OutboundProxyPort { get; set; }

        [XmlElement("outgoingTransport")]
        public string? OutgoingTransport { get; set; }

        [XmlElement("secureCiphers")]
        public string? SecureCiphers { get; set; }

        [XmlElement("sigDigits")]
        public int? SigDigits { get; set; }

        [XmlArray("sipHeaders")]
        [XmlArrayItem("sipHeader")]
        public List<SipHeader>? SipHeaders { get; set; }

        [XmlElement("supportedTLSVersion")]
        public string? SupportedTLSVersion { get; set; }

        [XmlElement("toneDuration")]
        public int? ToneDuration { get; set; }

        [XmlElement("useErrorRefer")]
        public bool? UseErrorRefer { get; set; }

        [XmlElement("useLocalSrv")]
        public bool? UseLocalSrv { get; set; }

        [XmlElement("useSrv")]
        public bool? UseSrv { get; set; }
    }
}