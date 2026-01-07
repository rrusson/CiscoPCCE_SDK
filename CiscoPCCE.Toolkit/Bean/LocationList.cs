using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("locations")]
public class LocationList : BaseApiBean {
  
  public List<Location>? Location { get; set; }

}

}