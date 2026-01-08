using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    public class TraceProcess : BaseApiBean
    {
        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("value")]
        public int? Value { get; set; }
    }
}