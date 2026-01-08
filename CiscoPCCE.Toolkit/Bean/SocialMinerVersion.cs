using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    public class SocialMinerVersion : BaseApiBean
    {
        [XmlElement("vosActiveVersion")]
        public string? VosActiveVersion { get; set; }
    }
}