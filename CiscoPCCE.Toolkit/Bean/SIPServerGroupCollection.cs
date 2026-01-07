using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("sipServerGroupCollection")]
public class SIPServerGroupCollection : BaseApiBean {
  
  public List<SIPServerGroupWrapper>? SipServerGroupList { get; set; }

}

}