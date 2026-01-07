using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("sipTriggers")]
public class SipTriggerXMLList : BaseApiBean {
  
  [XmlElement("sipTrigger")]
  public List<SipTrigger>? Items { get; set; }

}

}