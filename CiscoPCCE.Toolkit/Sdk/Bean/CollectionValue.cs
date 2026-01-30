using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("##default")]
    public class CollectionValue : BaseApiBean
    {
        [XmlElement("label")]
        public string? Label { get; set; }

        [XmlElement("value")]
        public string? Value { get; set; }
    }
}