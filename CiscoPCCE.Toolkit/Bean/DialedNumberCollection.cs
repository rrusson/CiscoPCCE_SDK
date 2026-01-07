using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("dialedNumberCollection")]
    public class DialedNumberCollection : BaseApiBean
    {
        public required Collection DialedNumberConfigs { get; set; }
    }
}