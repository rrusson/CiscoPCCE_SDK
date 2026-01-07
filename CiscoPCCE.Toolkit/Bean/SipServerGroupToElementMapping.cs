using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("SipServerGroupToElementMapping")]
public class SipServerGroupToElementMapping : BaseApiBean {
  
  public List<GroupType>? GroupTypes { get; set; }

}

}