using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    public class User : BaseApiBean
    {
        [XmlElement("id")]
        public string? Id { get; set; }

        [XmlElement("permission")]
        public string? Permission { get; set; }
    }
}