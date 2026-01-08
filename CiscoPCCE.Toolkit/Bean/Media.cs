using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    public class Media : BaseApiBean
    {
        private string? codec;
        private string? mrcpVersion;
        private bool? overrideSystemPrompt;

        [XmlElement("codec")]
        public string? Codec { get; set; }

        [XmlElement("mrcpVersion")]
        public string? MrcpVersion { get; set; }

        [XmlElement("overrideSystemPrompt")]
        public bool? OverrideSystemPrompt { get; set; }
    }
}