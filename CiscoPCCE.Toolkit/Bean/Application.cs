using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("application")]
    public class Application : BaseApiBean
    {
        public string? ApplicationName { get; set; }

        public string? Description { get; set; }

        public string? Enabled { get; set; }

        public required ICMPostRouting ICMPostRouting { get; set; }

        public required ICMTranslationRouting ICMTranslationRouting { get; set; }

        public int? Id { get; set; }

        public int Maxsession { get; set; }

        public required ScriptApplication ScriptApplication { get; set; }

        public string? Self { get; set; }

        public string? Type { get; set; }
    }
}