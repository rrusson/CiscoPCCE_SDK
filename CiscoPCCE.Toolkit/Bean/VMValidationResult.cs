using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("vmValidationResult")]
    public class VMValidationResult : BaseApiBean
    {
        [XmlElement("isValid")]
        public bool? IsValid { get; set; }

        [XmlArray("vmLayoutResults")]
        [XmlArrayItem("vmLayoutResult")]
        public List<VMLayoutResult>? LayoutResults { get; set; }
    }
}