using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{





[XmlRoot("errorDetail")]
public class VmHostErrorDetail : BaseApiBean {
  private List<VMHost>? hostNames;

  [XmlElement("hosts")]
  [XmlElement("hostInfo")]
  public List<VMHost>? HostNames
  {
      get => hostNames;
      set => hostNames = value;
  }


  public void setHostNames(List<VMHost> hostNames) {
     this.hostNames = hostNames;
  }


}

}