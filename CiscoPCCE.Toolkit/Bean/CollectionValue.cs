using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("##default")]
    public class CollectionValue : BaseApiBean
    {
        public string? Label { get; set; }

        public string? Value { get; set; }
    }
}