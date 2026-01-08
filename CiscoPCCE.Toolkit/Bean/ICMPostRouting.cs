using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    public class ICMPostRouting : BaseApiBean
    {
        [XmlElement("defaultScript")]
        public string? DefaultScript { get; set; }

        [XmlElement("initialScript")]
        public string? InitialScript { get; set; }

        [XmlElement("timeout")]
        public int Timeout { get; set; }
    }
}