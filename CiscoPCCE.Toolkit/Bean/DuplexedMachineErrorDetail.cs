using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("errorDetail")]
public class DuplexedMachineErrorDetail : BaseApiBean {
    
  public List<MachineType>? MachineTypes { get; set; }

  public string? PeriperhalSetName { get; set; }

}

}