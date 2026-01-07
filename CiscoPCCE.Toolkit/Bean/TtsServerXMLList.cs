using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("ttsServers")]
public class TtsServerXMLList : BaseApiBean {
  
  [XmlElement("ttsServer")]
  public List<TtsServer>? Items { get; set; }

}

}