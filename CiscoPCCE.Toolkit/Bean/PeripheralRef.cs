using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    public class PeripheralRef : BaseApiBean
    {
        [XmlElement("id")]
        public int? Id { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }
    }
}