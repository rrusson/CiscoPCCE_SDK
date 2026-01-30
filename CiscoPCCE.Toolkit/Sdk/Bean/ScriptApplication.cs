using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

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