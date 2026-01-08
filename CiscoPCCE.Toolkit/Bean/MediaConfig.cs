using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("media")]
    public class MediaConfig : BaseApiBean
    {
        private string? codec;
        private string? mRCPVersion;
        private bool? overrideSystemPrompt;

        [XmlElement("codec")]
        public string? Codec { get; set; }

        [XmlElement("mRCPVersion")]
        public string? MRCPVersion { get; set; }

        [XmlElement("overrideSystemPrompt")]
        public bool? OverrideSystemPrompt { get; set; }
    }
}