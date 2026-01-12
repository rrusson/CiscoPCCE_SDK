using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("asrServers")]
    public class AsrServerXMLList : BaseApiBean
    {
    [XmlElement("asrServer")]
        public List<AsrServer>? Items { get; set; }
    }
}