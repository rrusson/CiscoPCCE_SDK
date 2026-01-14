using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    public class SipTrigger : BaseApiBean
    {
        [XmlElement("label")]
        public List<string?>? Labels { get; set; }
    }
}