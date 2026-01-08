using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("errorDetail")]
    public class VmLayoutErrorDetail : BaseApiBean
    {
        [XmlArray("vmLayoutResults")]
        [XmlArrayItem("vmLayoutResult")]
        public List<VMLayoutResult>? LayoutResults { get; set; }
    }
}