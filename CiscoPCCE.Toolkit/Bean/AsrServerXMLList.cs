using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("asrServers")]
public class AsrServerXMLList : BaseApiBean {
  private List<AsrServer>? items;

  [XmlElement("asrServer")]
  public List<AsrServer>? Items
  {
      get => items;
      set => items = value;
  }


}

}