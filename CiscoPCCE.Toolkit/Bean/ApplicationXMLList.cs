using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("applications")]
public class ApplicationXMLList : BaseApiBean {
  private List<Application>? items;

  [XmlElement("application")]
  public List<Application>? Items
  {
      get => items;
      set => items = value;
  }


}

}