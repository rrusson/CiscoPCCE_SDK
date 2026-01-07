using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("sipServerGroupCollection")]
    public class SIPServerGroupCollection : BaseApiBean
    {
        public List<SIPServerGroupWrapper>? SipServerGroupList { get; set; }
    }
}