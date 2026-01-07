using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

public class DeviceInfo : BaseApiBean {
    
  [XmlElement("locations")]
  [XmlElement("location")]
  public List<string?>? Locations { get; set; }

  public string? TypeName { get; set; }

}

}