using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("errorDetail")]
public class MachineListErrorDetail : BaseApiBean {
    
  public string? ErrorType { get; set; }

  [XmlElement("machines")]
  [XmlElement("machine")]
  public Set Machines { get; set; }

}

}