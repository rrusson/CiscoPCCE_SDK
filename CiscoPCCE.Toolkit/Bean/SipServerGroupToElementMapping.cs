using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("SipServerGroupToElementMapping")]
    public class SipServerGroupToElementMapping : BaseApiBean
    {
        public List<GroupType>? GroupTypes { get; set; }
    }
}