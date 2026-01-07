using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("applications")]
public class ApplicationXMLList : BaseApiBean {
  
  [XmlElement("application")]
  public List<Application>? Items { get; set; }

}

}