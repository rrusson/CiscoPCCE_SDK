using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("VVB")]
    public class VVBServer : BaseApiBean
    {
        [XmlArray("applications")]
        [XmlArrayItem("application")]
        public List<Application>? Applications { get; set; }

        [XmlArray("asrServers")]
        [XmlArrayItem("asrServer")]
        public List<AsrServer>? AsrServers { get; set; }

        [XmlElement("baseUrlfromRefUrl")]
        public string? BaseUrlfromRefUrl { get; set; }

        [XmlElement("correlationId")]
        public string? CorrelationId { get; set; }

        [XmlElement("datacenter")]
        public required ReferenceBean Datacenter { get; set; }

        [XmlElement("department")]
        public required ReferenceBean Department { get; set; }

        [XmlElement("id")]
        public int? Id { get; set; }

        [XmlElement("idFromRefUrl")]
        public string? IdFromRefUrl { get; set; }

        [XmlElement("media")]
        public required MediaConfig Media { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }

        [XmlElement("security")]
        public required SecurityConfig Security { get; set; }

        [XmlArray("ttsServers")]
        [XmlArrayItem("ttsServer")]
        public List<TtsServer>? TtsServers { get; set; }
    }
}