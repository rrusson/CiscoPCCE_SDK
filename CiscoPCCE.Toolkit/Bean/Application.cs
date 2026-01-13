using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("application")]
    public class Application : BaseApiBean
    {
        [XmlElement("applicationName")]
        public string? ApplicationName { get; set; }

        [XmlElement("description")]
        public string? Description { get; set; }

        [XmlElement("enabled")]
        public string? Enabled { get; set; }

        [XmlElement("iCMPostRouting")]
        public required ICMPostRouting ICMPostRouting { get; set; }

        [XmlElement("iCMTranslationRouting")]
        public required ICMTranslationRouting ICMTranslationRouting { get; set; }

        [XmlElement("id")]
        public int? Id { get; set; }

        [XmlElement("maxsession")]
        public int Maxsession { get; set; }

        [XmlElement("scriptApplication")]
        public required ScriptApplication ScriptApplication { get; set; }

        [XmlElement("self")]
        public string? Self { get; set; }

        [XmlElement("type")]
        public string? Type { get; set; }
    }
}