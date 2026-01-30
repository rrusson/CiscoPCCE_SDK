using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("errorDetail")]
    public class VmLayoutErrorDetail : BaseApiBean
    {
        [XmlArray("vmLayoutResults")]
        [XmlArrayItem("vmLayoutResult")]
        public List<VMLayoutResult>? LayoutResults { get; set; }
    }
}