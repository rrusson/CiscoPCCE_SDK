using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("WrapUpReason")]
    public class WrapUpReasonsConfig : BaseApiBean
    {
        [XmlElement("forAll")]
        public string? ForAll { get; set; }

        [XmlElement("label")]
        public string? Label { get; set; }

        [XmlElement("uri")]
        public string? Uri { get; set; }
    }
}