using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("vvbInfo")]
    public class CVVBInfo : BaseApiBean
    {
        [XmlElement("vvbStatus")]
        public string? Status { get; set; }

        [XmlElement("vvbVersion")]
        public string? Version { get; set; }
    }
}