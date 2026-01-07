using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("errorDetail")]
public class ValueListErrorDetail : BaseApiBean {
  
  [XmlElement("invalidValues")]
  [XmlElement("invalidValue")]
  public List<string?>? InvalidValues { get; set; }

}

}