using System.Xml.Serialization;

using CiscoPCCE.Toolkit.Sdk;

namespace CiscoPCCE.Toolkit.Bean
{
    [XmlRoot("sipServerGroupCollection")]
    public class SIPServerGroupCollection : BaseApiBean
    {
        public List<SIPServerGroupWrapper>? SipServerGroupList { get; set; }
    }
}