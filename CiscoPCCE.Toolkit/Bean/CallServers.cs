using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("callServers")]
public class CallServers : BaseApiBean {
  
  [XmlElement("servers")]
  [XmlElement("server")]
  public List<CallServer>? ServerList { get; set; }

}

}