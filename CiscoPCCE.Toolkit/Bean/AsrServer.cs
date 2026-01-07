using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("asrServer")]
    public class AsrServer : BaseApiBean
    {
        public int? AsrServerId { get; set; }

        public string? AsrServerName { get; set; }

        public required Locales Locales { get; set; }

        public int PortNumber { get; set; }

        public string? ProviderName { get; set; }

        public string? Self { get; set; }

        public string? Status { get; set; }
    }
}