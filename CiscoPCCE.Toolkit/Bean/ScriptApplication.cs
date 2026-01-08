using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    public class ScriptApplication : BaseApiBean
    {
        [XmlElement("defaultScript")]
        public string? DefaultScript { get; set; }

        [XmlElement("script")]
        public string? Script { get; set; }
    }
}