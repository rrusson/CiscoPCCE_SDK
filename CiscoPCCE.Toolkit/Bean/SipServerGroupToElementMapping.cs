using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlType("SipServerGroupToElementMapping")]
    public class SipServerGroupToElementMapping : BaseApiBean
    {
        public List<GroupType>? GroupTypes { get; set; }
    }
}