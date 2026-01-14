using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class Media : BaseApiBean
    {
        [XmlElement("codec")]
        public string? Codec { get; set; }

        [XmlElement("mrcpVersion")]
        public string? MrcpVersion { get; set; }

        [XmlElement("overrideSystemPrompt")]
        public bool? OverrideSystemPrompt { get; set; }
    }
}