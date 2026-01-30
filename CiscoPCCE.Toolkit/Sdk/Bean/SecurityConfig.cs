using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("security")]
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