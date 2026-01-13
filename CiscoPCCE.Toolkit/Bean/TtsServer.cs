using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("ttsServer")]
    public class TtsServer : BaseApiBean
    {
        [XmlElement("port")]
        public int? Port { get; set; }

        [XmlElement("ttsServerName")]
        public string? TtsServerName { get; set; }
    }
}