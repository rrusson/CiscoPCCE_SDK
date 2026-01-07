using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("systemParam")]
    public class SystemParam : BaseApiBean
    {
        public required Media Media { get; set; }

        public required Security Security { get; set; }
    }
}