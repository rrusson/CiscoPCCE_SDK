using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("mediaServer")]
public class MediaServerConfig : BaseApiBean {
    
  public string? DefaultMediaServer { get; set; }

  [XmlElement("servers")]
  [XmlElement("server")]
  public List<MediaServer>? Servers { get; set; }

}

}