using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("errorDetail")]
public class VmHostErrorDetail : BaseApiBean {
  
  [XmlElement("hosts")]
  [XmlElement("hostInfo")]
  public List<VMHost>? HostNames { get; set; }

}

}