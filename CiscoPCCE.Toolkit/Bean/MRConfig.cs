using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("MRconfig")]
    public class MRConfig : BaseApiBean
    {
        [XmlElement("enabled")]
        public bool? Enabled { get; set; }

        [XmlElement("hostA")]
        public string? HostA { get; set; }

        [XmlElement("hostB")]
        public string? HostB { get; set; }

        [XmlElement("port")]
        public int Port { get; set; }
    }
}