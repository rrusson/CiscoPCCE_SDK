using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("Serviceability")]
    public class SocialMinerServiceability : BaseApiBean
    {
        [XmlElement("version")]
        public required SocialMinerVersion Version { get; set; }
    }
}