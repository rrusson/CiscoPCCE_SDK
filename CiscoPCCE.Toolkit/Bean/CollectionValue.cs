using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("##default")]
    public class CollectionValue : BaseApiBean
    {
        [XmlElement("label")]
        public string? Label { get; set; }

        [XmlElement("value")]
        public string? Value { get; set; }
    }
}