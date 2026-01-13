using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("ttsServers")]
    public class TtsServerXMLList : BaseApiBean
    {
        [XmlElement("ttsServer")]
        public List<TtsServer>? Items { get; set; }
    }
}