using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("sipTriggers")]
    public class SipTriggerXMLList : BaseApiBean
    {
        [XmlElement("sipTrigger")]
        public List<SipTrigger>? Items { get; set; }
    }
}