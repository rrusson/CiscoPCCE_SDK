using System.Xml.Serialization;

namespace CiscoPCCE.Toolkit.Bean
{

[XmlRoot("errorDetail")]
public class CuicAwMachineCountMismatchErrorDetail : BaseApiBean {
    
  public int? AwMachineCount { get; set; }

  public int? CuicMachineCount { get; set; }

}

}