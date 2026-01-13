using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("asrServer")]
    public class AsrServer : BaseApiBean
    {
        [XmlElement("asrServerId")]
        public int? AsrServerId { get; set; }

        [XmlElement("asrServerName")]
        public string? AsrServerName { get; set; }

        [XmlElement("locales")]
        public required Locales Locales { get; set; }

        [XmlElement("portNumber")]
        public int PortNumber { get; set; }

        [XmlElement("providerName")]
        public string? ProviderName { get; set; }

        [XmlElement("self")]
        public string? Self { get; set; }

        [XmlElement("status")]
        public string? Status { get; set; }
    }
}