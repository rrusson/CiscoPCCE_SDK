using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class MultiChannelPG : BaseApiBean
    {
        [XmlElement("configured")]
        public bool? Configured { get; set; }
    }
}