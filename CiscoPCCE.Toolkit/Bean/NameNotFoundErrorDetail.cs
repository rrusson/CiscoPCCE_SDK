using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("errorDetail")]
    public class NameNotFoundErrorDetail : BaseApiBean
    {
        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("type")]
        public string? Type { get; set; }
    }
}