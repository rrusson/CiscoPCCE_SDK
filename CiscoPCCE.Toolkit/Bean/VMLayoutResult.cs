using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

public class VMLayoutResult : BaseApiBean {
            
  public string? HardwareLayoutType { get; set; }

  public List<string?>? HostsWithoutProfiles { get; set; }

  public string? LayoutName { get; set; }

  public List<string?>? ProfilesWithoutHosts { get; set; }

  [XmlElement("vmResults")]
  [XmlElement("vmResult")]
  public List<VMServerData>? Results { get; set; }

  public bool? Valid { get; set; }

}

}