using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    public class NameUriPair : BaseApiBean
    {
        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("refURL")]
        public new string? RefURL { get; set; }
    }
}