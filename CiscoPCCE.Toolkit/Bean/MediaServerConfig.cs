using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("mediaServer")]
public class MediaServerConfig : BaseApiBean {
  private string? defaultMediaServer;
  private List<MediaServer>? servers;

  public string? DefaultMediaServer
  {
      get => defaultMediaServer;
      set => defaultMediaServer = value;
  }


  public void setDefaultMediaServer(String defaultMediaServer) {
     this.defaultMediaServer = defaultMediaServer;
  }

  [XmlElement("servers")]
  [XmlElement("server")]
  public List<MediaServer>? Servers
  {
      get => servers;
      set => servers = value;
  }


  public void setServers(List<MediaServer> servers) {
     this.servers = servers;
  }


}

}