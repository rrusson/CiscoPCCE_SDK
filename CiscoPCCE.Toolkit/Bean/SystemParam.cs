using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("systemParam")]
    public class SystemParam : BaseApiBean
    {
        [XmlElement("media")]
        public required Media Media { get; set; }

        [XmlElement("security")]
        public required Security Security { get; set; }
    }
}