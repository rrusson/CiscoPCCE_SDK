using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("VVB")]
    public class VVBServer : BaseApiBean
    {
        [XmlElement("applications")]
        [XmlElement("application")]
        public List<Application>? Applications { get; set; }

        [XmlElement("asrServers")]
        [XmlElement("asrServer")]
        public List<AsrServer>? AsrServers { get; set; }

        public string? BaseUrlfromRefUrl { get; set; }

        public string? CorrelationId { get; set; }

        public required ReferenceBean Datacenter { get; set; }

        public required ReferenceBean Department { get; set; }

        public int? Id { get; set; }

        public string? IdFromRefUrl { get; set; }

        public required MediaConfig Media { get; set; }

        public new string? RefURL { get; set; }

        public required SecurityConfig Security { get; set; }

        [XmlElement("ttsServers")]
        [XmlElement("ttsServer")]
        public List<TtsServer>? TtsServers { get; set; }
    }
}