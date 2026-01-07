using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("sipTriggers")]
public class SipTriggerXMLList : BaseApiBean {
  private List<SipTrigger>? items;

  [XmlElement("sipTrigger")]
  public List<SipTrigger>? Items
  {
      get => items;
      set => items = value;
  }


}

}