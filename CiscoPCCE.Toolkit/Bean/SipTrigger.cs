using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

public class SipTrigger : BaseApiBean {
  
  [XmlElement("label")]
  public List<string?>? Labels { get; set; }

}

}