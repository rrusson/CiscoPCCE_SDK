using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("vmValidationResult")]
public class VMValidationResult : BaseApiBean {
    
  [XmlElement("isValid")]
  public bool? IsValid { get; set; }

  [XmlElement("vmLayoutResults")]
  [XmlElement("vmLayoutResult")]
  public List<VMLayoutResult>? LayoutResults { get; set; }

}

}