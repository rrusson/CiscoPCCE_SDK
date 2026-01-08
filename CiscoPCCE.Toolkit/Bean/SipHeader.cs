using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    public class SipHeader : BaseApiBean
    {
        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("value")]
        public string? Value { get; set; }
    }
}