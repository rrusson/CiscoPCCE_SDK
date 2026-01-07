using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("vvbInfo")]
    public class CVVBInfo : BaseApiBean
    {
        [XmlElement("vvbStatus")]
        public string? Status { get; set; }

        [XmlElement("vvbVersion")]
        public string? Version { get; set; }
    }
}