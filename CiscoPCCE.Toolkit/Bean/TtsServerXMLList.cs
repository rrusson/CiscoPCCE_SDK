using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("ttsServers")]
public class TtsServerXMLList : BaseApiBean {
  private List<TtsServer>? items;

  [XmlElement("ttsServer")]
  public List<TtsServer>? Items
  {
      get => items;
      set => items = value;
  }


}

}