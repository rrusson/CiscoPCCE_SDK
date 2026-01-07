using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("asrServers")]
public class AsrServerXMLList : BaseApiBean {
  
  [XmlElement("asrServer")]
  public List<AsrServer>? Items { get; set; }

}

}