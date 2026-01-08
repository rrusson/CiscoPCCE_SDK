using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("systemParam")]
    public class SystemParam : BaseApiBean
    {
        [XmlElement("media")]
        public required Media Media { get; set; }

        [XmlElement("security")]
        public required Security Security { get; set; }
    }
}