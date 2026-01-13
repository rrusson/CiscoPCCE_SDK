using System.Xml.Serialization;
using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class Alert : BaseApiBean
    {
        [XmlElement("apiErrors")]
        public required ApiErrors Errors { get; set; }

        [XmlElement("machine")]
        public required Machine Machine { get; set; }
    }
}