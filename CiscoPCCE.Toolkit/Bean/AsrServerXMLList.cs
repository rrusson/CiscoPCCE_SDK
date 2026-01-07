using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("asrServers")]
    public class AsrServerXMLList : BaseApiBean
    {
        [XmlElement("asrServer")]
        public List<AsrServer>? Items { get; set; }
    }
}