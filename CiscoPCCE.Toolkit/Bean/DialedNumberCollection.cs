using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("dialedNumberCollection")]
    public class DialedNumberCollection : BaseApiBean
    {
        [XmlElement("dialedNumberConfigs")]
        public required Collection DialedNumberConfigs { get; set; }
    }
}