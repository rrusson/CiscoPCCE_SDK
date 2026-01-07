using System.Xml.Serialization;
using System.Collections.Generic;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("errorDetail")]
public class MachineTypeNumberOutOfRangeErrorDetail : BaseApiBean {
          
  public int? Actual { get; set; }

  public List<MachineType>? MachineTypes { get; set; }

  public int? Max { get; set; }

  public int? Min { get; set; }

  public string? PeripheralSetName { get; set; }

}

}