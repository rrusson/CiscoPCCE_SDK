using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("callServers")]
public class CallServers : BaseApiBean {
  private List<CallServer>? callServers;

  [XmlElement("servers")]
  [XmlElement("server")]
  public List<CallServer>? CallServers
  {
      get => callServers;
      set => callServers = value;
  }


  public void setCallServers(List<CallServer> callServers) {
     this.callServers = callServers;
  }


}

}