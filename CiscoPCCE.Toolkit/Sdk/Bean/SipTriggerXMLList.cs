using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("sipTriggers")]
    public class SipTriggerXMLList : BaseApiBean
    {
        [XmlElement("sipTrigger")]
        public List<SipTrigger>? Items { get; set; }
    }
}