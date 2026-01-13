using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("mediaServer")]
    public class MediaServerConfig : BaseApiBean
    {
        [XmlElement("defaultMediaServer")]
        public string? DefaultMediaServer { get; set; }

        [XmlArray("servers")]
        [XmlArrayItem("server")]
        public List<MediaServer>? Servers { get; set; }
    }
}