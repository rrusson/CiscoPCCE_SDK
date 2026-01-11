using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class AtomLink : BaseApiBean
    {
        [XmlElement("href")]
        public string? Href { get; set; }

        [XmlElement("rel")]
        public string? Rel { get; set; }

        [XmlElement("type")]
        public string? Type { get; set; }
    }
}