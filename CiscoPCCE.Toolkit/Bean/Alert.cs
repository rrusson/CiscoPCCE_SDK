using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    public class Alert : BaseApiBean
    {
        [XmlElement("apiErrors")]
        public required ApiErrors Errors { get; set; }

        public required Machine Machine { get; set; }
    }
}