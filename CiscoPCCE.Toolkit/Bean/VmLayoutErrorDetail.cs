using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("errorDetail")]
    public class VmLayoutErrorDetail : BaseApiBean
    {
        [XmlElement("vmLayoutResults")]
        [XmlElement("vmLayoutResult")]
        public List<VMLayoutResult>? LayoutResults { get; set; }
    }
}