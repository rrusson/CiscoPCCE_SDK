using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class SocialMinerVersion : BaseApiBean
    {
        [XmlElement("vosActiveVersion")]
        public string? VosActiveVersion { get; set; }
    }
}