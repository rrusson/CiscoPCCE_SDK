using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("media")]
    public class MediaConfig : BaseApiBean
    {
        private string? codec;
        private string? mRCPVersion;
        private bool? overrideSystemPrompt;

        public string? Codec { get; set; }

        public string? MRCPVersion { get; set; }

        public bool? OverrideSystemPrompt { get; set; }
    }
}