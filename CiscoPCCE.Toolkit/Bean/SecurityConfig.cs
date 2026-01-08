using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("security")]
    public class SecurityConfig : BaseApiBean
    {
        [XmlElement("allowMixedMode")]
        public bool? AllowMixedMode { get; set; }

        [XmlElement("ciphers")]
        public required Ciphers Ciphers { get; set; }

        [XmlElement("sipTLSEnabled")]
        public bool? SipTLSEnabled { get; set; }

        [XmlElement("srtpEnabled")]
        public bool? SrtpEnabled { get; set; }

        [XmlElement("tlsVersion")]
        public string? TlsVersion { get; set; }
    }
}