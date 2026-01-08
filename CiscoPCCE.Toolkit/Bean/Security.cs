using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    public class Security : BaseApiBean
    {
        [XmlElement("allowMixedMode")]
        public bool? AllowMixedMode { get; set; }

        [XmlElement("ciphers")]
        public required Ciphers Ciphers { get; set; }

        [XmlElement("sipTLSEnabled")]
        public bool? SipTLSEnabled { get; set; }

        [XmlElement("srtp")]
        public bool? Srtp { get; set; }

        [XmlElement("tlsVersion")]
        public string? TlsVersion { get; set; }
    }
}