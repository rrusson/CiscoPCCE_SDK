using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("Serviceability")]
    public class SocialMinerServiceability : BaseApiBean
    {
        public required SocialMinerVersion Version { get; set; }
    }
}