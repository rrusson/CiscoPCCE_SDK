using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    public class VMAddress : BaseApiBean
    {
        [XmlElement("ipAddress")]
        public string? IpAddress { get; set; }

        [XmlElement("name")]
        public string? Name { get; set; }

        [XmlElement("networkType")]
        public string? NetworkType { get; set; }
    }
}