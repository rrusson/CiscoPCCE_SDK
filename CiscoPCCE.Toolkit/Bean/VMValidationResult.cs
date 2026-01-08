using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("vmValidationResult")]
    public class VMValidationResult : BaseApiBean
    {
        [XmlElement("isValid")]
        public bool? IsValid { get; set; }

        [XmlArray("vmLayoutResults")]
        [XmlArrayItem("vmLayoutResult")]
        public List<VMLayoutResult>? LayoutResults { get; set; }
    }
}