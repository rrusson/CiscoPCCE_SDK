using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("SipServerGroupToElementMapping")]
    public class SipServerGroupToElementMapping : BaseApiBean
    {
        public List<GroupType>? GroupTypes { get; set; }
    }
}