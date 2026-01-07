using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    public class SipTrigger : BaseApiBean
    {
        [XmlElement("label")]
        public List<string?>? Labels { get; set; }
    }
}