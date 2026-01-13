using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("dialedNumberCollection")]
    public class DialedNumberCollection : BaseApiBean
    {
        [XmlElement("dialedNumberConfigs")]
        public required Collection DialedNumberConfigs { get; set; }
    }
}