using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("media")]
    public class MediaConfig : BaseApiBean
    {
        [XmlElement("codec")]
        public string? Codec { get; set; }

        [XmlElement("mRCPVersion")]
        public string? MRCPVersion { get; set; }

        [XmlElement("overrideSystemPrompt")]
        public bool? OverrideSystemPrompt { get; set; }
    }
}